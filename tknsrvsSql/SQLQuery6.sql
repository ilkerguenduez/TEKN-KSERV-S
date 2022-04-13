Create Trigger stokazalt
on TBLURUNHAREKET
after insert as
declare @URUN int
declare @ADET int
select @URUN=URUN,@ADET=ADET from inserted
update TBLURUN set STOK-=@ADET WHERE ID=@URUN