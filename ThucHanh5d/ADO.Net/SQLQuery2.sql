USE QLSINHVIEN;
GO
 
INSERT INTO Khoa (MaKhoa, TenKhoa)
SELECT v.MaKhoa, v.TenKhoa
FROM (VALUES ('1', N'Công nghệ thông tin'),
             ('2', N'Toán - Ứng dụng'),
             ('3', N'Ngoại ngữ')) AS v(MaKhoa, TenKhoa)
WHERE NOT EXISTS (SELECT 1 FROM Khoa k WHERE k.MaKhoa = v.MaKhoa);
 
INSERT INTO Lop (MaLop, TenLop, MaKhoa)
SELECT v.MaLop, v.TenLop, v.MaKhoa
FROM (VALUES ('05DHTH1', N'Đại học Tin học 1', '1'),
             ('05DHTH2', N'Đại học Tin học 2', '1'),
             ('05DHTT1', N'Đại học Toán tin 1', '2')) AS v(MaLop, TenLop, MaKhoa)
WHERE NOT EXISTS (SELECT 1 FROM Lop l WHERE l.MaLop = v.MaLop);
 
INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop)
SELECT v.MaSinhVien, v.HoTen, v.NgaySinh, v.MaLop
FROM (VALUES ('SV001', N'Nguyễn Văn An',  CAST('2005-03-12' AS DATE), '05DHTH1'),
             ('SV002', N'Trần Thị Bình',  CAST('2005-07-25' AS DATE), '05DHTH1'),
             ('SV003', N'Lê Hoàng Cường', CAST('2004-11-02' AS DATE), '05DHTH2'),
             ('SV004', N'Phạm Minh Dũng', CAST('2005-01-18' AS DATE), '05DHTT1')) AS v(MaSinhVien, HoTen, NgaySinh, MaLop)
WHERE NOT EXISTS (SELECT 1 FROM SinhVien s WHERE s.MaSinhVien = v.MaSinhVien);
 
INSERT INTO MonHoc (MaMonHoc, TenMonHoc)
SELECT v.MaMonHoc, v.TenMonHoc
FROM (VALUES ('MH01', N'Lập trình C#'),
             ('MH02', N'Cơ sở dữ liệu'),
             ('MH03', N'Mạng máy tính')) AS v(MaMonHoc, TenMonHoc)
WHERE NOT EXISTS (SELECT 1 FROM MonHoc m WHERE m.MaMonHoc = v.MaMonHoc);
 
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem)
SELECT v.MaSinhVien, v.MaMonHoc, v.Diem
FROM (VALUES ('SV001', 'MH01', 8.5),
             ('SV001', 'MH02', 7.0),
             ('SV002', 'MH01', 9.0),
             ('SV003', 'MH03', 6.5)) AS v(MaSinhVien, MaMonHoc, Diem)
WHERE NOT EXISTS (SELECT 1 FROM Diem d WHERE d.MaSinhVien = v.MaSinhVien AND d.MaMonHoc = v.MaMonHoc);
GO
 
SELECT * FROM Khoa; SELECT * FROM Lop; SELECT * FROM SinhVien; SELECT * FROM MonHoc; SELECT * FROM Diem;
 