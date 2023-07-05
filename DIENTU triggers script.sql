create or alter trigger SUMAUTO
on GioHang
For INSERT, UPDATE
as
Begin
	declare @SL int
	declare @Sale int
	declare @Price numeric(18,0)
	declare @Price2 numeric(18,0)
	declare @User nvarchar(50)
	declare @IDSP int

	select @SL = B.SL, @Sale = A.GiamGia, @Price = A.GiaTien, @User = B.UserName, @IDSP = B.MaSP
	from SanPham A inner join inserted B
	on A.MaSP = B.MaSP

	set @Price2 = @SL * (@Price * (100 - @Sale)/100)
	 
	 update GioHang
	 set SumAll = @Price2
	 Where UserName = @User and MaSP = @IDSP
End

go

create or alter trigger MAXHANG
on GioHang
For INSERT, UPDATE
as
Begin
	declare @IDSP int
	declare @kho int
	declare @sumSP int

	select @IDSP = B.MaSP, @kho = A.SLKho
	from SanPham A inner join inserted B
	on A.MaSP = B.MaSP

	select @sumSP = SUM(SL)
	from GioHang
	where MaSP = @IDSP
	group by MaSP

	if(@sumSP > @kho)
	begin
		RAISERROR ('SL SP VUOT QUA SL KHO', 16, 1)
        ROLLBACK TRANSACTION
	end
END
