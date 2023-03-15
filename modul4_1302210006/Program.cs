// See https://aka.ms/new-console-template for more information
using modul4_1302210006;

KodeBuah_1302210006.buah Buah = KodeBuah_1302210006.buah.Apel;
string kBuah = KodeBuah_1302210006.getKodeBuah_1302210006(Buah);
Console.WriteLine("Nama buah: " + Buah + " \nKode Buah: " + kBuah);

PosisiKarakterGame_1302210006 objChara = new PosisiKarakterGame_1302210006();
objChara.activateTrigger_1302210006(PosisiKarakterGame_1302210006.btnTrigger.TombolW);
objChara.activateTrigger_1302210006(PosisiKarakterGame_1302210006.btnTrigger.TombolS);
objChara.activateTrigger_1302210006(PosisiKarakterGame_1302210006.btnTrigger.TombolX);
objChara.implementasiModNim(PosisiKarakterGame_1302210006.stateChara.Berdiri, PosisiKarakterGame_1302210006.btnTrigger.TombolS);
