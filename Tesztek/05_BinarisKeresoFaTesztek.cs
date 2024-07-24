// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using OE.ALGA.Adatszerkezetek;
// 
// namespace OE.ALGA.Tesztek
// {
//     [TestClass()]
//     public class FaHalmazTesztek
//     {
//         [TestMethod()]
//         public void Beszuras()
//         {
//             Halmaz<int> v = new FaHalmaz<int>();
//             v.Beszur(1);
//             v.Beszur(3);
//             v.Beszur(2);
//             Assert.IsTrue(v.Eleme(1));
//             Assert.IsTrue(v.Eleme(2));
//             Assert.IsTrue(v.Eleme(3));
//             Assert.IsFalse(v.Eleme(4));
//         }
// 
//         [TestMethod()]
//         public void Torles()
//         {
//             Halmaz<int> v = new FaHalmaz<int>();
//             v.Beszur(1);
//             v.Beszur(3);
//             v.Beszur(2);
//             v.Torol(2);
//             Assert.IsTrue(v.Eleme(1));
//             Assert.IsFalse(v.Eleme(2));
//             Assert.IsTrue(v.Eleme(3));
//             Assert.IsFalse(v.Eleme(4));
//         }
// 
//         [TestMethod()]
//         public void DuplaBeszuras()
//         {
//             Halmaz<int> v = new FaHalmaz<int>();
//             v.Beszur(1);
//             v.Beszur(2);
//             v.Beszur(3);
//             v.Beszur(2);
//             v.Torol(2);
//             Assert.IsTrue(v.Eleme(1));
//             Assert.IsFalse(v.Eleme(2));
//             Assert.IsTrue(v.Eleme(3));
//             Assert.IsFalse(v.Eleme(4));
//         }
//     }
// }
