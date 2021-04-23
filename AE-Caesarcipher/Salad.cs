using System;

using AE_Caesarcipher.Algorithm;

namespace AE_Caesarcipher
{
    public static class Salad
    {
        static void Main(string[] args)
        {
            var cipher1 = new Cipher("Hello World!", false);
            var cipher2 = new Cipher("Xbtx pmmf oxjs usjo " +
                                            "lfot jfcf oUbh fmbo hXbt " +
                                            "xpmm foxj susj olfo tpfj oEvs tuFt " +
                                            "xjse hfov hgüs bmmf tfjo Xjsu sjol " +
                                            "foav tbnn fosp mmeb tGbt tnbm sfjo " +
                                            "Xjsu sjol foav tbnn fooj diub mmfj " +
                                            "oFtx jseh fovh güsb mmft fjoX jsus " +
                                            "jolf oavt bnnf ospm mebt Gbtt nbms " +
                                            "fjoX jsus jolf oavt bnnf oojd iubm mfjo " +
                                            "Eboo xpmm foxj stdi bggf otjf coUb hfmb " +
                                            "ohEb ooxp mmfo xjst dibg gfol pnng bttb " +
                                            "oEbo oxpm mfox jstd ibgg fotj fcfo Ubhf " +
                                            "mboh Eboo xpmm foxj stdi bggf olpn ngbt " +
                                            "tboV oeeb txjs elfj ofQm bdlf sfjX jstd " +
                                            "ibgg foav tbnn fotj fcfo Ubhf mboh Kbtd " +
                                            "ibgg foav tbnn fooj diub mmfj oVoe ebtx " +
                                            "jsel fjof Qmbd lfsf jXjs tdib ggfo avtb " +
                                            "nnfo tjfc foUb hfmb ohKb tdib ggfo avtb " +
                                            "nnfo ojdi ubmm fjo", true);

            var cipher1_c = Caesarcipher.Cipher(cipher1, 6);
            var cipher2_c = Caesarcipher.Decipher(cipher2, 1);
            var cipher1_dc = Caesarcipher.Decipher(cipher1_c, 6);

            Console.WriteLine(cipher1 + Environment.NewLine);
            Console.WriteLine(cipher2 + Environment.NewLine);
            Console.WriteLine(cipher1_c + Environment.NewLine);
            Console.WriteLine(cipher2_c + Environment.NewLine);
            Console.WriteLine(cipher1_dc + Environment.NewLine);

            Console.ReadLine();
        }
    }
}
