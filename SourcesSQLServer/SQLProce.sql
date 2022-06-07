CREATE VIEW v_GetSubcribers
AS
	SELECT TENKHOA = PUBS.description, subscriber_server AS TENSERVER
	FROM sysmergepublications PUBS, sysmergesubscriptions SUBS
	WHERE PUBS.pubid = SUBS.pubid
	AND publisher<>subscriber_server

CREATE PROC sp_Lay_Thong_Tin_SV_Tu_Login
	@TenLogin nvarchar(100)
as
	DECLARE @UID int
	DECLARE @MaSV varchar(10)

	SELECT @UID = uid, @MaSV = name
	FROM sys.sysusers
	WHERE sid  = SUSER_SID(@TenLogin)

	SELECT MaSV = @MaSV, HoSV = (SELECT HoSV FROM SINHVIEN WHERE MASV = @MaSV), TENSV = (SELECT TENSV FROM SINHVIEN WHERE MASV = @MaSV)
	FROM sys.sysusers
	WHERE uid = (SELECT groupuid FROM sys.sysmembers WHERE memberuid = @UID)

CREATE PROC sp_Lay_Thong_Tin_GV_Tu_Login
	@TenLogin nvarchar(100)
as
	DECLARE @UID int
	DECLARE @MaGV varchar(10)

	SELECT @UID = uid, @MaGV = name
	FROM sys.sysusers
	WHERE sid  = SUSER_SID(@TenLogin)

	SELECT MaGV = @MaGV, HOGV = (SELECT HOGV FROM GIANGVIEN WHERE MAGV = @MaGV), TENGV = (SELECT TENGV FROM GIANGVIEN WHERE MAGV = @MaGV)
	FROM sys.sysusers
	WHERE uid = (SELECT groupuid FROM sys.sysmembers WHERE memberuid = @UID)
CREATE PROCEDURE sp_Timsinhvien
	@masv varchar(10)
AS
	if exists (	SELECT * FROM SINHVIEN WHERE MASV = @masv)
	begin
		SELECT K.MAKHOA, TENKHOA, MASV, HoSV, TENSV
		FROM KHOA K, SINHVIEN SV, LOP L
		WHERE K.MAKHOA = L.MAKHOA AND L.MALOP = SV.MALOP
		AND SV.MASV = @masv
	end
	else
		if exists( SELECT * FROM LINK1.QuanLyDiem.DBO.SINHVIEN WHERE MASV = @masv)
		begin
			SELECT K.MAKHOA, TENKHOA, MASV, HoSV, TENSV
			FROM LINK1.QuanLyDiem.DBO.KHOA K, LINK1.QuanLyDiem.DBO.SINHVIEN SV, LINK1.QuanLyDiem.DBO.LOP L
			WHERE K.MAKHOA = L.MAKHOA AND L.MALOP = SV.MALOP
			AND SV.MASV = @masv
		end
		else
			if exists( SELECT * FROM LINK2.QuanLyDiem.DBO.SINHVIEN WHERE MASV = @masv)
			begin
				SELECT K.MAKHOA, TENKHOA, MASV, HoSV, TENSV
				FROM LINK2.QuanLyDiem.DBO.KHOA K, LINK2.QuanLyDiem.DBO.SINHVIEN SV, LINK2.QuanLyDiem.DBO.LOP L
				WHERE K.MAKHOA = L.MAKHOA AND L.MALOP = SV.MALOP
				AND SV.MASV = @masv
			end
			else
				raiserror('khong tim thay sinh vien',16,1)



CREATE PROCEDURE sp_Timgiangvien
	@magv varchar(10)
AS
	if exists (	SELECT * FROM GIANGVIEN WHERE MAGV = @magv)
	begin
		SELECT K.MAKHOA, TENKHOA, MAGV, HOGV, TENGV
		FROM KHOA K, GIANGVIEN GV
		WHERE K.MAKHOA = GV.MAKHOA
		AND GV.MAGV = @magv
	end
	else
		if exists( SELECT * FROM LINK1.QuanLyDiem.DBO.GIANGVIEN WHERE MAGV = @magv)
		begin
			SELECT K.MAKHOA, TENKHOA, MAGV, HOGV, TENGV
			FROM LINK1.QuanLyDiem.DBO.KHOA K, LINK1.QuanLyDiem.DBO.GIANGVIEN GV
			WHERE K.MAKHOA = GV.MAKHOA
				AND GV.MAGV = @magv
		end
		else
			if exists( SELECT * FROM LINK2.QuanLyDiem.DBO.GIANGVIEN WHERE MAGV = @magv)
			begin
				SELECT K.MAKHOA, TENKHOA, MAGV, HOGV, TENGV
				FROM LINK2.QuanLyDiem.DBO.KHOA K, LINK2.QuanLyDiem.DBO.GIANGVIEN GV
				WHERE K.MAKHOA = GV.MAKHOA
					AND GV.MAGV = @magv
			end
			else
				raiserror('khong tim thay giao vien',16,1)

CREATE PROCEDURE sp_Xoasinhvien
	@masv varchar(10)
AS
	if exists (	SELECT * FROM SINHVIEN WHERE MASV = @masv)
	begin
		SELECT MASV
		INTO #TEMP
		FROM  SINHVIEN
		WHERE MASV = @masv

		DELETE FROM DIEM
		WHERE MASV IN (SELECT MASV FROM #TEMP)

		DELETE FROM SINHVIEN
		WHERE MASV = @masv
	end
	else
		if exists( SELECT * FROM LINK1.QuanLyDiem.DBO.SINHVIEN WHERE MASV = @masv)
		begin
			SELECT MASV
			INTO #TEMP1
			FROM  LINK1.QuanLyDiem.DBO.SINHVIEN
			WHERE MASV = @masv

			DELETE FROM LINK1.QuanLyDiem.DBO.DIEM
			WHERE MASV IN (SELECT MASV FROM #TEMP1)

			DELETE FROM LINK1.QuanLyDiem.DBO.SINHVIEN
			WHERE MASV = @masv
		end
		else
			if exists( SELECT * FROM LINK2.QuanLyDiem.DBO.SINHVIEN WHERE MASV = @masv)
			begin
				SELECT MASV
				INTO #TEMP2
				FROM  LINK2.QuanLyDiem.DBO.SINHVIEN
				WHERE MASV = @masv

				DELETE FROM LINK2.QuanLyDiem.DBO.DIEM
				WHERE MASV IN (SELECT MASV FROM #TEMP2)

				DELETE FROM LINK2.QuanLyDiem.DBO.SINHVIEN
				WHERE MASV = @masv
			end
			else
				raiserror('khong tim thay sinh vien can xoa',16,1)


CREATE PROCEDURE sp_Xoagiangvien
	@magv varchar(10)
AS
	if exists (	SELECT * FROM GIANGVIEN WHERE MAGV = @magv)
	begin
		SELECT MAGV
		INTO #TEMP3
		FROM  GIANGVIEN
		WHERE MAGV = @magv

		SELECT MALTC
		INTO #TEMP7
		FROM  LOPTINCHI 
		WHERE MAGV = @magv

		DELETE FROM DIEM
		WHERE MALTC IN (SELECT MALTC FROM #TEMP7)

		DELETE FROM LOPTINCHI
		WHERE MAGV IN (SELECT MAGV FROM #TEMP3)

		DELETE FROM GIANGVIEN
		WHERE MAGV = @magv
	end
	else
		if exists( SELECT * FROM LINK1.QuanLyDiem.DBO.GIANGVIEN WHERE MAGV = @magv)
		begin
			SELECT MAGV
			INTO #TEMP4
			FROM  LINK1.QuanLyDiem.DBO.GIANGVIEN
			WHERE MAGV = @magv

			SELECT MALTC
			INTO #TEMP8
			FROM  LINK1.QuanLyDiem.DBO.LOPTINCHI 
			WHERE MAGV = @magv

			DELETE FROM LINK1.QuanLyDiem.DBO.DIEM
			WHERE MALTC IN (SELECT MALTC FROM #TEMP8)

			DELETE FROM LINK1.QuanLyDiem.DBO.LOPTINCHI
			WHERE MAGV IN (SELECT MAGV FROM #TEMP4)

			DELETE FROM LINK1.QuanLyDiem.DBO.GIANGVIEN
			WHERE MAGV = @magv
		end
		else
			if exists( SELECT * FROM LINK2.QuanLyDiem.DBO.GIANGVIEN WHERE MAGV = @magv)
			begin
				SELECT MAGV
				INTO #TEMP5
				FROM  LINK2.QuanLyDiem.DBO.GIANGVIEN
				WHERE MAGV = @magv

				SELECT MALTC
				INTO #TEMP9
				FROM  LINK2.QuanLyDiem.DBO.LOPTINCHI 
				WHERE MAGV = @magv
				
				DELETE FROM LINK2.QuanLyDiem.DBO.DIEM
				WHERE MALTC IN (SELECT MALTC FROM #TEMP9)

				DELETE FROM LINK2.QuanLyDiem.DBO.LOPTINCHI
				WHERE MAGV IN (SELECT MAGV FROM #TEMP5)

				DELETE FROM LINK2.QuanLyDiem.DBO.GIANGVIEN
				WHERE MAGV = @magv
			end
			else
				raiserror('khong tim thay giang vien can xoa',16,1)


CREATE PROC sp_BangDiem
AS
	SELECT D.MASV, HoSV, TENSV, MALTC, DIEM_QT, DIEM_GK,DIEM_CK 
	FROM DIEM D, (SELECT MASV, HoSV, TENSV FROM SINHVIEN ) AS SV
	WHERE D.MASV = SV.MASV