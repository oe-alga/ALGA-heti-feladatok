// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using OE.ALGA.Optimalizalas;
// 
// namespace OE.ALGA.Tesztek
// {
//     [TestClass()]
//     public class VisszalepesesKeresesTesztek
//     {
//         [TestMethod()]
//         public void JegyzetbenLevoPeldaErtekTeszt()
//         {
//             HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.jegyzet_n, PakolasTesztEsetek.jegyzet_Wmax, PakolasTesztEsetek.jegyzet_w, PakolasTesztEsetek.jegyzet_p);
//             VisszalepesesHatizsakPakolas opt = new VisszalepesesHatizsakPakolas(problema);
//             Assert.AreEqual(PakolasTesztEsetek.jegyzet_optimalis_ertek, opt.OptimalisErtek());
//         }
// 
//         [TestMethod()]
//         public void JegyzetbenLevoPeldaMegoldasTeszt()
//         {
//             HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.jegyzet_n, PakolasTesztEsetek.jegyzet_Wmax, PakolasTesztEsetek.jegyzet_w, PakolasTesztEsetek.jegyzet_p);
//             VisszalepesesHatizsakPakolas opt = new VisszalepesesHatizsakPakolas(problema);
//             CollectionAssert.AreEqual(PakolasTesztEsetek.jegyzet_optimalis_pakolas, opt.OptimalisMegoldas());
//         }
// 
//         [TestMethod()]
//         public void NagyPeldaMegoldasTeszt()
//         {
//             HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.nagy_n, PakolasTesztEsetek.nagy_Wmax, PakolasTesztEsetek.nagy_w, PakolasTesztEsetek.nagy_p);
//             VisszalepesesHatizsakPakolas opt = new VisszalepesesHatizsakPakolas(problema);
//             Assert.AreEqual(PakolasTesztEsetek.nagy_optimalis_ertek, opt.OptimalisErtek());
//         }
// 
//         [TestMethod()]
//         public void LepesszamVizsgalat()
//         {
//             HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.nagy_n, PakolasTesztEsetek.nagy_Wmax, PakolasTesztEsetek.nagy_w, PakolasTesztEsetek.nagy_p);
//             VisszalepesesHatizsakPakolas opt = new VisszalepesesHatizsakPakolas(problema);
//             Assert.AreEqual(PakolasTesztEsetek.nagy_optimalis_ertek, opt.OptimalisErtek());
//             Console.WriteLine("Lépésszám: " + opt.LepesSzam);
//         }
//     }
// 
//     [TestClass()]
//     public class SzetvalasztasEsKorlatozasTesztek
//     {
//         [TestMethod()]
//         public void JegyzetbenLevoPeldaErtekTeszt()
//         {
//             HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.jegyzet_n, PakolasTesztEsetek.jegyzet_Wmax, PakolasTesztEsetek.jegyzet_w, PakolasTesztEsetek.jegyzet_p);
//             SzetvagasEsKorlatozasHatizsakPakolas opt = new SzetvagasEsKorlatozasHatizsakPakolas(problema);
//             Assert.AreEqual(PakolasTesztEsetek.jegyzet_optimalis_ertek, opt.OptimalisErtek());
//         }
// 
//         [TestMethod()]
//         public void JegyzetbenLevoPeldaMegoldasTeszt()
//         {
//             HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.jegyzet_n, PakolasTesztEsetek.jegyzet_Wmax, PakolasTesztEsetek.jegyzet_w, PakolasTesztEsetek.jegyzet_p);
//             SzetvagasEsKorlatozasHatizsakPakolas opt = new SzetvagasEsKorlatozasHatizsakPakolas(problema);
//             CollectionAssert.AreEqual(PakolasTesztEsetek.jegyzet_optimalis_pakolas, opt.OptimalisMegoldas());
//         }
// 
//         [TestMethod()]
//         public void NagyPeldaMegoldasTeszt()
//         {
//             HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.nagy_n, PakolasTesztEsetek.nagy_Wmax, PakolasTesztEsetek.nagy_w, PakolasTesztEsetek.nagy_p);
//             SzetvagasEsKorlatozasHatizsakPakolas opt = new SzetvagasEsKorlatozasHatizsakPakolas(problema);
//             Assert.AreEqual(PakolasTesztEsetek.nagy_optimalis_ertek, opt.OptimalisErtek());
//         }
// 
//         [TestMethod()]
//         public void LepesszamVizsgalat()
//         {
//             HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.nagy_n, PakolasTesztEsetek.nagy_Wmax, PakolasTesztEsetek.nagy_w, PakolasTesztEsetek.nagy_p);
//             SzetvagasEsKorlatozasHatizsakPakolas opt = new SzetvagasEsKorlatozasHatizsakPakolas(problema);
//             Assert.AreEqual(PakolasTesztEsetek.nagy_optimalis_ertek, opt.OptimalisErtek());
//             Console.WriteLine("Lépésszám: " + opt.LepesSzam);
//         }
//     }
// }
