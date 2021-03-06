//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using NUnit.Framework;
using static Unity.Mathematics.FixedPoint.fpmath;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.FixedPoint.Tests
{
    [TestFixture]
    public class TestFp2x3
    {
        [Test]
        public static void fp2x3_zero()
        {
            TestUtils.AreEqual(fp2x3.zero.c0.x, (fp)0);
            TestUtils.AreEqual(fp2x3.zero.c0.y, (fp)0);
            TestUtils.AreEqual(fp2x3.zero.c1.x, (fp)0);
            TestUtils.AreEqual(fp2x3.zero.c1.y, (fp)0);
            TestUtils.AreEqual(fp2x3.zero.c2.x, (fp)0);
            TestUtils.AreEqual(fp2x3.zero.c2.y, (fp)0);
        }

        [Test]
        public static void fp2x3_operator_equal_wide_wide()
        {
            fp2x3 a0 = fp2x3(-135.18924m, -49.0941162m, 169.129822m, 240.8053m, 314.7392m, 442.393m);
            fp2x3 b0 = fp2x3(-220.014648m, 66.98004m, 499.2016m, -371.1131m, 208.448669m, 390.8037m);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            fp2x3 a1 = fp2x3(177.924438m, 335.5334m, 168.15448m, 350.729553m, 367.178467m, 46.9414673m);
            fp2x3 b1 = fp2x3(-72.44382m, 362.97644m, 194.678345m, 471.644836m, -404.044678m, -144.696747m);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            fp2x3 a2 = fp2x3(188.76416m, -97.2113953m, -293.320984m, -234.822937m, 417.0337m, 26.3864136m);
            fp2x3 b2 = fp2x3(-494.446655m, -252.970367m, 234.417114m, 398.724m, 260.4287m, 370.144226m);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            fp2x3 a3 = fp2x3(269.245728m, 29.4741821m, 479.485229m, -237.230957m, -221.9837m, -506.672546m);
            fp2x3 b3 = fp2x3(89.579834m, -434.816833m, -109.845337m, 336.973022m, -409.154968m, 500.387573m);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public static void fp2x3_operator_equal_wide_scalar()
        {
            fp2x3 a0 = fp2x3(65.6712m, 404.415527m, -269.730164m, 83.6306152m, 152.9945m, -155.868286m);
            fp b0 = (-155.815765m);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            fp2x3 a1 = fp2x3(314.671265m, 290.04895m, -132.6352m, -65.66748m, -69.68326m, -191.190765m);
            fp b1 = (386.365173m);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            fp2x3 a2 = fp2x3(186.845215m, -319.144043m, -49.70108m, -300.8819m, 333.396851m, 386.3775m);
            fp b2 = (-232.895691m);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            fp2x3 a3 = fp2x3(-296.7019m, 141.542358m, -227.323334m, 83.87286m, -410.91687m, 110.501282m);
            fp b3 = (-309.1172m);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public static void fp2x3_operator_equal_scalar_wide()
        {
            fp a0 = (36.38391m);
            fp2x3 b0 = fp2x3(-400.4892m, -71.2868347m, 156.978088m, -225.238739m, 499.141785m, -211.979919m);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            fp a1 = (428.311951m);
            fp2x3 b1 = fp2x3(-489.501343m, -5.691559m, -30.8659363m, -362.9831m, 184.503174m, -160.470612m);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            fp a2 = (316.668823m);
            fp2x3 b2 = fp2x3(390.369263m, 505.1051m, -294.6487m, 443.1991m, 96.5592651m, -257.012939m);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            fp a3 = (-245.054962m);
            fp2x3 b3 = fp2x3(326.464844m, -23.9599m, -168.694885m, 386.2486m, -227.090637m, -336.612427m);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public static void fp2x3_operator_not_equal_wide_wide()
        {
            fp2x3 a0 = fp2x3(279.994141m, -43.34201m, -465.724731m, 317.466553m, 85.7149658m, 360.8905m);
            fp2x3 b0 = fp2x3(-460.9121m, -476.009033m, 468.1364m, -341.012543m, -62.65805m, -458.801666m);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            fp2x3 a1 = fp2x3(366.081543m, 154.542847m, 332.4262m, 397.11322m, -431.374969m, 489.0108m);
            fp2x3 b1 = fp2x3(-457.730225m, -59.5232544m, 3.024231m, 155.812744m, -19.8399048m, -6.01693726m);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            fp2x3 a2 = fp2x3(398.4336m, -489.817932m, 171.4049m, -67.82968m, -192.278717m, 227.84082m);
            fp2x3 b2 = fp2x3(-406.207916m, -102.420715m, -40.362915m, 452.6754m, 93.25757m, -258.378052m);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            fp2x3 a3 = fp2x3(62.1381836m, 262.186462m, -404.0531m, 34.449585m, -204.795776m, -285.4118m);
            fp2x3 b3 = fp2x3(-184.0498m, -379.2353m, -370.687317m, -255.947235m, 29.0557861m, 322.407654m);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public static void fp2x3_operator_not_equal_wide_scalar()
        {
            fp2x3 a0 = fp2x3(-155.4411m, -19.4266052m, 174.633057m, 507.920715m, 59.177063m, 171.151489m);
            fp b0 = (-393.413544m);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            fp2x3 a1 = fp2x3(-58.92328m, 492.20105m, -165.241516m, 270.341m, -380.243256m, 501.899048m);
            fp b1 = (-398.176849m);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            fp2x3 a2 = fp2x3(-134.345459m, 46.7709961m, 161.459961m, 261.514221m, -145.6124m, -0.449920654m);
            fp b2 = (458.400452m);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            fp2x3 a3 = fp2x3(350.461426m, 242.664m, 382.677063m, -468.967957m, -497.459473m, -80.93225m);
            fp b3 = (202.221008m);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public static void fp2x3_operator_not_equal_scalar_wide()
        {
            fp a0 = (478.353149m);
            fp2x3 b0 = fp2x3(459.553223m, 436.453247m, -488.714172m, 392.767944m, -266.736633m, 338.557861m);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            fp a1 = (-338.100128m);
            fp2x3 b1 = fp2x3(-152.314545m, -452.820679m, 209.439331m, 50.10797m, 372.4344m, -488.0213m);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            fp a2 = (489.740784m);
            fp2x3 b2 = fp2x3(270.4001m, -472.846771m, -286.850464m, -384.691864m, 443.423523m, 358.7472m);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            fp a3 = (-15.4140625m);
            fp2x3 b3 = fp2x3(-342.179169m, 468.967529m, -130.568085m, 401.785828m, -268.352264m, -239.231018m);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }


    }
}
