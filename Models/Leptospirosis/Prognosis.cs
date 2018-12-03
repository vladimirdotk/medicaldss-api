  
    using System;
    
    namespace medicaldss_api.Models.Leptospirosis
    {
      public class Prognosis
      {
        
        public static string N_386_MLP_7_30_6(double[] ContInputs)
        {

            //"Input Variable" comment is added besides Input(Response) variables.

            int Cont_idx = 0;

            double Tromb_N = ContInputs[Cont_idx++]; //Input Variable

            double PTI_N = ContInputs[Cont_idx++]; //Input Variable

            double Fibrinogen_N = ContInputs[Cont_idx++]; //Input Variable

            double APTV_N = ContInputs[Cont_idx++]; //Input Variable

            double Sag_N = ContInputs[Cont_idx++]; //Input Variable

            double FV_N = ContInputs[Cont_idx++]; //Input Variable

            double RKFM_N = ContInputs[Cont_idx++]; //Input Variable

            string __statist_PredCat = "";

            string[] __statist_DCats = new string[6];

            __statist_DCats[0] = "ДВС";

            __statist_DCats[1] = "КП";

            __statist_DCats[2] = "ИТ";

            __statist_DCats[3] = "нет коагулопатии";

            __statist_DCats[4] = "печеночная";

            __statist_DCats[5] = "уремическая";



            double __statist_ConfLevel = 3.0E-300;



            double[] __statist_max_input = new double[7];

            __statist_max_input[0] = 1.52000000000000e+000;

            __statist_max_input[1] = 9.79090909090909e-001;

            __statist_max_input[2] = 3.60333333333333e+000;

            __statist_max_input[3] = 2.05714285714286e+000;

            __statist_max_input[4] = 3.44972375690608e+000;

            __statist_max_input[5] = 1.82000000000000e+000;

            __statist_max_input[6] = 8.61764705882353e+000;



            double[] __statist_min_input = new double[7];

            __statist_min_input[0] = 2.33333333333333e-002;

            __statist_min_input[1] = 4.00000000000000e-001;

            __statist_min_input[2] = 5.33333333333333e-001;

            __statist_min_input[3] = 6.74285714285714e-001;

            __statist_min_input[4] = 5.34254143646409e-001;

            __statist_min_input[5] = 3.20000000000000e-001;

            __statist_min_input[6] = 5.88235294117647e-003;





            double[,] __statist_i_h_wts = new double[30, 7];



            __statist_i_h_wts[0, 0] = 1.34354462632065e+000;

            __statist_i_h_wts[0, 1] = 1.38275332075705e-001;

            __statist_i_h_wts[0, 2] = -1.26339383103272e+000;

            __statist_i_h_wts[0, 3] = 6.24461862346715e-002;

            __statist_i_h_wts[0, 4] = -1.45162220252453e+000;

            __statist_i_h_wts[0, 5] = 7.14365692169205e-001;

            __statist_i_h_wts[0, 6] = -5.19176076982149e-001;



            __statist_i_h_wts[1, 0] = -1.14613533504658e+000;

            __statist_i_h_wts[1, 1] = -2.56249513536096e-001;

            __statist_i_h_wts[1, 2] = -2.37690150763980e-001;

            __statist_i_h_wts[1, 3] = 3.01004245820399e-001;

            __statist_i_h_wts[1, 4] = 1.85469330143214e+000;

            __statist_i_h_wts[1, 5] = -1.16914304666323e+000;

            __statist_i_h_wts[1, 6] = -1.18275671381217e+000;



            __statist_i_h_wts[2, 0] = -4.08751236008193e-001;

            __statist_i_h_wts[2, 1] = -4.97925758679796e-001;

            __statist_i_h_wts[2, 2] = -6.34143372401070e-001;

            __statist_i_h_wts[2, 3] = 4.25215386980194e-001;

            __statist_i_h_wts[2, 4] = 1.35350517850315e-001;

            __statist_i_h_wts[2, 5] = -3.45786674884051e-002;

            __statist_i_h_wts[2, 6] = 3.23693045162755e+000;



            __statist_i_h_wts[3, 0] = -2.75556907921267e+000;

            __statist_i_h_wts[3, 1] = -7.55377606980410e-001;

            __statist_i_h_wts[3, 2] = 1.20295929782458e+000;

            __statist_i_h_wts[3, 3] = -7.07666110003879e-001;

            __statist_i_h_wts[3, 4] = 2.20147353790545e+000;

            __statist_i_h_wts[3, 5] = 6.22089092123812e-001;

            __statist_i_h_wts[3, 6] = -1.14111603628135e+000;



            __statist_i_h_wts[4, 0] = 1.71957552209455e+000;

            __statist_i_h_wts[4, 1] = 1.27031549909181e-001;

            __statist_i_h_wts[4, 2] = -2.27499676838706e+000;

            __statist_i_h_wts[4, 3] = 5.63225593848788e-001;

            __statist_i_h_wts[4, 4] = -1.13644491321557e+000;

            __statist_i_h_wts[4, 5] = 3.08890132611312e-001;

            __statist_i_h_wts[4, 6] = 7.59677858325884e-001;



            __statist_i_h_wts[5, 0] = 2.01510190776576e+000;

            __statist_i_h_wts[5, 1] = 1.30456081301361e+000;

            __statist_i_h_wts[5, 2] = -2.36424862615629e+000;

            __statist_i_h_wts[5, 3] = 1.18654906906563e+000;

            __statist_i_h_wts[5, 4] = -1.14740349213618e+000;

            __statist_i_h_wts[5, 5] = -7.69204319723451e-001;

            __statist_i_h_wts[5, 6] = -3.24058548355050e-001;



            __statist_i_h_wts[6, 0] = -5.97775786966733e-001;

            __statist_i_h_wts[6, 1] = -6.47952464196807e-001;

            __statist_i_h_wts[6, 2] = -1.99943070832010e-001;

            __statist_i_h_wts[6, 3] = 1.12939965809682e+000;

            __statist_i_h_wts[6, 4] = -1.11928032260821e+000;

            __statist_i_h_wts[6, 5] = 1.88568661359997e-001;

            __statist_i_h_wts[6, 6] = 2.20809090303514e+000;



            __statist_i_h_wts[7, 0] = -1.04803182766144e+000;

            __statist_i_h_wts[7, 1] = 9.04104926232026e-001;

            __statist_i_h_wts[7, 2] = -3.40177441211777e-001;

            __statist_i_h_wts[7, 3] = 1.15441212906460e+000;

            __statist_i_h_wts[7, 4] = 1.43634150908597e+000;

            __statist_i_h_wts[7, 5] = -3.24577029066595e+000;

            __statist_i_h_wts[7, 6] = -1.17031906258043e+000;



            __statist_i_h_wts[8, 0] = 5.37236888031793e-001;

            __statist_i_h_wts[8, 1] = -4.12218113547951e-001;

            __statist_i_h_wts[8, 2] = -1.52199538298356e+000;

            __statist_i_h_wts[8, 3] = 6.26422564886203e-001;

            __statist_i_h_wts[8, 4] = -4.49378483033949e-001;

            __statist_i_h_wts[8, 5] = -5.18941365147812e-002;

            __statist_i_h_wts[8, 6] = 6.64663478953547e-001;



            __statist_i_h_wts[9, 0] = 1.65487710954060e+000;

            __statist_i_h_wts[9, 1] = 2.32208775095831e+000;

            __statist_i_h_wts[9, 2] = -1.94895797706876e+000;

            __statist_i_h_wts[9, 3] = 1.86200662277800e+000;

            __statist_i_h_wts[9, 4] = 6.69565260552708e-001;

            __statist_i_h_wts[9, 5] = -6.84259087390668e-001;

            __statist_i_h_wts[9, 6] = -1.36065230021726e+000;



            __statist_i_h_wts[10, 0] = 3.86287455038141e-001;

            __statist_i_h_wts[10, 1] = 2.98608652891453e-001;

            __statist_i_h_wts[10, 2] = -2.93009658569943e-001;

            __statist_i_h_wts[10, 3] = 6.96948775785080e-001;

            __statist_i_h_wts[10, 4] = -2.25832694437712e-001;

            __statist_i_h_wts[10, 5] = -1.28966194986313e+000;

            __statist_i_h_wts[10, 6] = 1.62396447234137e+000;



            __statist_i_h_wts[11, 0] = -2.50053433780707e-001;

            __statist_i_h_wts[11, 1] = 9.38116029083707e-002;

            __statist_i_h_wts[11, 2] = 1.19835886288492e+000;

            __statist_i_h_wts[11, 3] = -1.88133633005054e+000;

            __statist_i_h_wts[11, 4] = 1.70148871479218e+000;

            __statist_i_h_wts[11, 5] = 1.87223782642986e+000;

            __statist_i_h_wts[11, 6] = -6.97549339733534e-001;



            __statist_i_h_wts[12, 0] = 1.57236583624878e+000;

            __statist_i_h_wts[12, 1] = 1.37549875576645e+000;

            __statist_i_h_wts[12, 2] = -4.56336376449186e-001;

            __statist_i_h_wts[12, 3] = 9.86275417846196e-001;

            __statist_i_h_wts[12, 4] = -1.52344175431952e+000;

            __statist_i_h_wts[12, 5] = -2.70005748331408e+000;

            __statist_i_h_wts[12, 6] = 2.26794418467158e-001;



            __statist_i_h_wts[13, 0] = 7.63798655069890e-001;

            __statist_i_h_wts[13, 1] = -1.95053793287707e-001;

            __statist_i_h_wts[13, 2] = -2.82552916473917e+000;

            __statist_i_h_wts[13, 3] = 1.43554232603308e-001;

            __statist_i_h_wts[13, 4] = 5.30663794496038e-001;

            __statist_i_h_wts[13, 5] = -7.94769280806129e-001;

            __statist_i_h_wts[13, 6] = -3.64310228037125e+000;



            __statist_i_h_wts[14, 0] = -2.09894915459298e+000;

            __statist_i_h_wts[14, 1] = 1.40128897865297e-003;

            __statist_i_h_wts[14, 2] = 5.59464378485957e+000;

            __statist_i_h_wts[14, 3] = -1.97831514932257e+000;

            __statist_i_h_wts[14, 4] = 2.92009551691080e+000;

            __statist_i_h_wts[14, 5] = 1.89160289820574e+000;

            __statist_i_h_wts[14, 6] = 2.08055844276216e+000;



            __statist_i_h_wts[15, 0] = -2.79386168406093e+000;

            __statist_i_h_wts[15, 1] = -7.24314250688757e-001;

            __statist_i_h_wts[15, 2] = 2.19189119784286e+000;

            __statist_i_h_wts[15, 3] = 3.03803605336731e-001;

            __statist_i_h_wts[15, 4] = 3.33106512683465e-001;

            __statist_i_h_wts[15, 5] = 1.51835971935587e+000;

            __statist_i_h_wts[15, 6] = 3.23833821829235e+000;



            __statist_i_h_wts[16, 0] = 3.59161702934718e+000;

            __statist_i_h_wts[16, 1] = 1.84911567279824e+000;

            __statist_i_h_wts[16, 2] = -5.53805097266750e+000;

            __statist_i_h_wts[16, 3] = 3.31193554497700e+000;

            __statist_i_h_wts[16, 4] = -1.86821674467487e+000;

            __statist_i_h_wts[16, 5] = -2.45399101183444e+000;

            __statist_i_h_wts[16, 6] = -2.04228430774576e+000;



            __statist_i_h_wts[17, 0] = 1.23649783645003e+000;

            __statist_i_h_wts[17, 1] = 4.19752892020463e-001;

            __statist_i_h_wts[17, 2] = -3.47726751211730e-001;

            __statist_i_h_wts[17, 3] = -1.40220759072690e-001;

            __statist_i_h_wts[17, 4] = -1.03220451952048e+000;

            __statist_i_h_wts[17, 5] = 1.49382177478790e-001;

            __statist_i_h_wts[17, 6] = 1.77167412068010e+000;



            __statist_i_h_wts[18, 0] = -1.22384515958591e+000;

            __statist_i_h_wts[18, 1] = 1.15754473468984e-001;

            __statist_i_h_wts[18, 2] = -8.27435928362139e-001;

            __statist_i_h_wts[18, 3] = 6.85861236061303e-001;

            __statist_i_h_wts[18, 4] = 2.73997330061695e+000;

            __statist_i_h_wts[18, 5] = -2.52513486164264e+000;

            __statist_i_h_wts[18, 6] = -2.88957769427559e+000;



            __statist_i_h_wts[19, 0] = -2.06346995663873e+000;

            __statist_i_h_wts[19, 1] = 4.03044464738564e-001;

            __statist_i_h_wts[19, 2] = 6.11197762460283e+000;

            __statist_i_h_wts[19, 3] = -1.98500275105657e+000;

            __statist_i_h_wts[19, 4] = 1.60408651998954e+000;

            __statist_i_h_wts[19, 5] = 4.22568871188671e+000;

            __statist_i_h_wts[19, 6] = 2.26559017489944e+000;



            __statist_i_h_wts[20, 0] = -1.15827295514025e-001;

            __statist_i_h_wts[20, 1] = 4.97598385470177e-001;

            __statist_i_h_wts[20, 2] = 2.94439483999842e-001;

            __statist_i_h_wts[20, 3] = 7.77202519988501e-001;

            __statist_i_h_wts[20, 4] = -6.69639657156874e-001;

            __statist_i_h_wts[20, 5] = -1.18483759091267e+000;

            __statist_i_h_wts[20, 6] = 2.54182927939004e+000;



            __statist_i_h_wts[21, 0] = 1.18184688433784e+000;

            __statist_i_h_wts[21, 1] = 5.57156248696493e-001;

            __statist_i_h_wts[21, 2] = -4.32426039473946e-001;

            __statist_i_h_wts[21, 3] = -4.11211883154769e-001;

            __statist_i_h_wts[21, 4] = -3.67640514830551e-001;

            __statist_i_h_wts[21, 5] = -6.33146496724291e-001;

            __statist_i_h_wts[21, 6] = -6.75048125183042e-001;



            __statist_i_h_wts[22, 0] = -3.11674711789545e+000;

            __statist_i_h_wts[22, 1] = -2.13737358963045e+000;

            __statist_i_h_wts[22, 2] = 3.25332201852952e+000;

            __statist_i_h_wts[22, 3] = -1.84476158370729e+000;

            __statist_i_h_wts[22, 4] = 2.19093475559848e+000;

            __statist_i_h_wts[22, 5] = 1.12534512618605e+000;

            __statist_i_h_wts[22, 6] = 1.74943600055561e+000;



            __statist_i_h_wts[23, 0] = 6.91505193442257e-001;

            __statist_i_h_wts[23, 1] = 2.34342980570403e-001;

            __statist_i_h_wts[23, 2] = 1.49592524737225e-001;

            __statist_i_h_wts[23, 3] = -8.71404318188576e-001;

            __statist_i_h_wts[23, 4] = -2.97414579571675e-001;

            __statist_i_h_wts[23, 5] = 5.66045050089196e-001;

            __statist_i_h_wts[23, 6] = -3.35429943128310e+000;



            __statist_i_h_wts[24, 0] = 2.56302024305017e+000;

            __statist_i_h_wts[24, 1] = -1.31660482135497e-001;

            __statist_i_h_wts[24, 2] = -4.52278797593423e+000;

            __statist_i_h_wts[24, 3] = 1.62293308587759e+000;

            __statist_i_h_wts[24, 4] = -3.92199812312825e+000;

            __statist_i_h_wts[24, 5] = -4.89520643670615e-001;

            __statist_i_h_wts[24, 6] = -2.41567675190220e+000;



            __statist_i_h_wts[25, 0] = 1.12802216522798e+000;

            __statist_i_h_wts[25, 1] = -3.63190036423033e-002;

            __statist_i_h_wts[25, 2] = -1.79033022469371e+000;

            __statist_i_h_wts[25, 3] = 5.33708796051197e-001;

            __statist_i_h_wts[25, 4] = -1.02953939958487e+000;

            __statist_i_h_wts[25, 5] = -4.86743936378207e-001;

            __statist_i_h_wts[25, 6] = -7.01514806248901e-001;



            __statist_i_h_wts[26, 0] = -7.17349362815021e-001;

            __statist_i_h_wts[26, 1] = -2.62109940666329e-001;

            __statist_i_h_wts[26, 2] = 3.44331666554053e+000;

            __statist_i_h_wts[26, 3] = -1.17178625686703e+000;

            __statist_i_h_wts[26, 4] = 4.67383176803634e-001;

            __statist_i_h_wts[26, 5] = 2.78050704972527e+000;

            __statist_i_h_wts[26, 6] = 1.77559847341233e+000;



            __statist_i_h_wts[27, 0] = -2.50330766855313e-001;

            __statist_i_h_wts[27, 1] = -2.36281975315067e-001;

            __statist_i_h_wts[27, 2] = 5.92456085711408e-002;

            __statist_i_h_wts[27, 3] = -1.07628009367948e+000;

            __statist_i_h_wts[27, 4] = 1.23290019963020e+000;

            __statist_i_h_wts[27, 5] = 1.42111832506142e+000;

            __statist_i_h_wts[27, 6] = -2.19830049508334e+000;



            __statist_i_h_wts[28, 0] = -2.87382795645848e-002;

            __statist_i_h_wts[28, 1] = -5.57042189231407e-001;

            __statist_i_h_wts[28, 2] = -2.16144118359452e+000;

            __statist_i_h_wts[28, 3] = 1.25535583592807e+000;

            __statist_i_h_wts[28, 4] = -4.09610052865483e-001;

            __statist_i_h_wts[28, 5] = -1.78939410873820e+000;

            __statist_i_h_wts[28, 6] = -4.45453611037514e-001;



            __statist_i_h_wts[29, 0] = -2.01222845572635e+000;

            __statist_i_h_wts[29, 1] = -7.91337910703021e-001;

            __statist_i_h_wts[29, 2] = 5.82131932965515e+000;

            __statist_i_h_wts[29, 3] = -1.96641297248660e+000;

            __statist_i_h_wts[29, 4] = 1.07234774159322e+000;

            __statist_i_h_wts[29, 5] = 4.31241136723703e+000;

            __statist_i_h_wts[29, 6] = 3.25976154940277e+000;



            double[,] __statist_h_o_wts = new double[6, 30];



            __statist_h_o_wts[0, 0] = -2.29277035494040e-001;

            __statist_h_o_wts[0, 1] = -9.92883039942880e-002;

            __statist_h_o_wts[0, 2] = 2.83389474256718e+000;

            __statist_h_o_wts[0, 3] = -1.96402030655290e-001;

            __statist_h_o_wts[0, 4] = 1.42064946753821e+000;

            __statist_h_o_wts[0, 5] = -1.07510452588367e-001;

            __statist_h_o_wts[0, 6] = -2.98829160074041e-002;

            __statist_h_o_wts[0, 7] = -9.53681690860886e-001;

            __statist_h_o_wts[0, 8] = 6.61106827551286e-001;

            __statist_h_o_wts[0, 9] = -5.86978733242184e+000;

            __statist_h_o_wts[0, 10] = 1.13687381420578e+000;

            __statist_h_o_wts[0, 11] = 1.53295742098492e+000;

            __statist_h_o_wts[0, 12] = -1.06468644714904e+000;

            __statist_h_o_wts[0, 13] = -2.83498022306598e+000;

            __statist_h_o_wts[0, 14] = 3.35856425516326e+000;

            __statist_h_o_wts[0, 15] = 1.06042706098736e+000;

            __statist_h_o_wts[0, 16] = -6.76338939543146e+000;

            __statist_h_o_wts[0, 17] = 2.38477593776702e+000;

            __statist_h_o_wts[0, 18] = -1.39403956409924e+000;

            __statist_h_o_wts[0, 19] = 4.50189867261572e+000;

            __statist_h_o_wts[0, 20] = 8.10315311886908e-001;

            __statist_h_o_wts[0, 21] = 5.43298234840286e-001;

            __statist_h_o_wts[0, 22] = 3.33320297418256e+000;

            __statist_h_o_wts[0, 23] = -2.57234555518662e+000;

            __statist_h_o_wts[0, 24] = -4.47839433804731e+000;

            __statist_h_o_wts[0, 25] = -5.96013134152177e-002;

            __statist_h_o_wts[0, 26] = 2.43804323408067e+000;

            __statist_h_o_wts[0, 27] = -6.94616740089295e-001;

            __statist_h_o_wts[0, 28] = -1.50005269098747e+000;

            __statist_h_o_wts[0, 29] = 6.08500967528232e+000;



            __statist_h_o_wts[1, 0] = -1.38592425704336e+000;

            __statist_h_o_wts[1, 1] = 5.86427984046142e-001;

            __statist_h_o_wts[1, 2] = 9.76034600138320e-001;

            __statist_h_o_wts[1, 3] = 6.96499860129970e-002;

            __statist_h_o_wts[1, 4] = -9.13866035155865e-001;

            __statist_h_o_wts[1, 5] = -2.78052676187238e-001;

            __statist_h_o_wts[1, 6] = 1.60843284910737e+000;

            __statist_h_o_wts[1, 7] = 2.36589485387654e+000;

            __statist_h_o_wts[1, 8] = -5.67474878285680e-001;

            __statist_h_o_wts[1, 9] = 1.46501259160409e+000;

            __statist_h_o_wts[1, 10] = 1.20958922448664e+000;

            __statist_h_o_wts[1, 11] = -2.21537896980891e+000;

            __statist_h_o_wts[1, 12] = 1.94821347227748e+000;

            __statist_h_o_wts[1, 13] = -7.55891626990906e-001;

            __statist_h_o_wts[1, 14] = -2.38399014950398e-001;

            __statist_h_o_wts[1, 15] = 1.87202911113525e+000;

            __statist_h_o_wts[1, 16] = 1.86811727365868e+000;

            __statist_h_o_wts[1, 17] = 3.89124605215398e-001;

            __statist_h_o_wts[1, 18] = 3.44322999899013e-001;

            __statist_h_o_wts[1, 19] = -1.76832071847513e+000;

            __statist_h_o_wts[1, 20] = 3.16004627546512e+000;

            __statist_h_o_wts[1, 21] = -7.37230130728988e-001;

            __statist_h_o_wts[1, 22] = -5.48528681003357e-001;

            __statist_h_o_wts[1, 23] = -1.78733488806851e+000;

            __statist_h_o_wts[1, 24] = 8.80091738463101e-001;

            __statist_h_o_wts[1, 25] = -6.91376305415782e-001;

            __statist_h_o_wts[1, 26] = -7.79223559929038e-001;

            __statist_h_o_wts[1, 27] = -2.93628344683882e+000;

            __statist_h_o_wts[1, 28] = 1.06556458280061e+000;

            __statist_h_o_wts[1, 29] = -1.49696728952430e+000;



            __statist_h_o_wts[2, 0] = -8.19508449756805e-001;

            __statist_h_o_wts[2, 1] = 2.07784557267248e+000;

            __statist_h_o_wts[2, 2] = -1.48296151410810e+000;

            __statist_h_o_wts[2, 3] = 3.43877302311869e+000;

            __statist_h_o_wts[2, 4] = -2.31833608916055e+000;

            __statist_h_o_wts[2, 5] = -1.77223812598237e+000;

            __statist_h_o_wts[2, 6] = -1.64726889406988e+000;

            __statist_h_o_wts[2, 7] = 1.06906719977984e+000;

            __statist_h_o_wts[2, 8] = -1.00145211032792e+000;

            __statist_h_o_wts[2, 9] = 2.81019519039051e-001;

            __statist_h_o_wts[2, 10] = -9.06755994238259e-001;

            __statist_h_o_wts[2, 11] = 1.45760750924422e+000;

            __statist_h_o_wts[2, 12] = -2.07084008837597e+000;

            __statist_h_o_wts[2, 13] = 2.00235510300393e+000;

            __statist_h_o_wts[2, 14] = 3.16861746562848e-001;

            __statist_h_o_wts[2, 15] = 9.86731597236757e-002;

            __statist_h_o_wts[2, 16] = -2.35334857292618e+000;

            __statist_h_o_wts[2, 17] = -2.84217761263167e+000;

            __statist_h_o_wts[2, 18] = 3.15626401510500e+000;

            __statist_h_o_wts[2, 19] = 5.68552781693333e-001;

            __statist_h_o_wts[2, 20] = -2.47862653846567e+000;

            __statist_h_o_wts[2, 21] = -8.04278335933113e-001;

            __statist_h_o_wts[2, 22] = 1.41853947508038e+000;

            __statist_h_o_wts[2, 23] = 1.40303532267468e+000;

            __statist_h_o_wts[2, 24] = -1.27216217442078e+000;

            __statist_h_o_wts[2, 25] = -7.56624465823220e-001;

            __statist_h_o_wts[2, 26] = -7.33498506916181e-001;

            __statist_h_o_wts[2, 27] = 2.53368402027967e+000;

            __statist_h_o_wts[2, 28] = 2.59687710632196e-001;

            __statist_h_o_wts[2, 29] = -1.03204372858195e+000;



            __statist_h_o_wts[3, 0] = 7.78498401718358e-001;

            __statist_h_o_wts[3, 1] = -9.05428925122787e-001;

            __statist_h_o_wts[3, 2] = -2.17587139477999e+000;

            __statist_h_o_wts[3, 3] = -1.31103657282216e+000;

            __statist_h_o_wts[3, 4] = -2.98149770194449e-001;

            __statist_h_o_wts[3, 5] = 1.01842456236333e+000;

            __statist_h_o_wts[3, 6] = -1.41706534015821e+000;

            __statist_h_o_wts[3, 7] = 1.41788430937429e-001;

            __statist_h_o_wts[3, 8] = -5.97406501211785e-001;

            __statist_h_o_wts[3, 9] = 9.63794870149415e-001;

            __statist_h_o_wts[3, 10] = -1.41624298020205e-001;

            __statist_h_o_wts[3, 11] = 1.24311894251173e-001;

            __statist_h_o_wts[3, 12] = 2.31249030703367e+000;

            __statist_h_o_wts[3, 13] = 5.21294877768555e-001;

            __statist_h_o_wts[3, 14] = -1.84779772323302e-001;

            __statist_h_o_wts[3, 15] = -2.91083213427214e+000;

            __statist_h_o_wts[3, 16] = 7.55364289274044e-001;

            __statist_h_o_wts[3, 17] = -2.48530753918357e-001;

            __statist_h_o_wts[3, 18] = -4.47367605719627e-002;

            __statist_h_o_wts[3, 19] = -5.97505077993718e-001;

            __statist_h_o_wts[3, 20] = -1.72193054651591e-001;

            __statist_h_o_wts[3, 21] = 1.13718199457579e+000;

            __statist_h_o_wts[3, 22] = -1.31203269248493e+000;

            __statist_h_o_wts[3, 23] = 2.25907583499506e+000;

            __statist_h_o_wts[3, 24] = 6.51533257248408e-001;

            __statist_h_o_wts[3, 25] = 5.88639329925308e-001;

            __statist_h_o_wts[3, 26] = -3.92667553737233e-001;

            __statist_h_o_wts[3, 27] = -2.29164650875700e-001;

            __statist_h_o_wts[3, 28] = -6.21428984052914e-001;

            __statist_h_o_wts[3, 29] = -1.21409077438569e+000;



            __statist_h_o_wts[4, 0] = 2.48287127290956e-001;

            __statist_h_o_wts[4, 1] = 2.98936412462419e-001;

            __statist_h_o_wts[4, 2] = -3.00810182164291e-001;

            __statist_h_o_wts[4, 3] = -5.97434041441088e-001;

            __statist_h_o_wts[4, 4] = 9.65544727116315e-001;

            __statist_h_o_wts[4, 5] = 5.78337521012675e-001;

            __statist_h_o_wts[4, 6] = 1.05543155057056e+000;

            __statist_h_o_wts[4, 7] = -5.46194610195692e-001;

            __statist_h_o_wts[4, 8] = 1.16228638911795e+000;

            __statist_h_o_wts[4, 9] = 2.36685475866937e+000;

            __statist_h_o_wts[4, 10] = -4.27553983697095e-001;

            __statist_h_o_wts[4, 11] = -1.51934116661270e+000;

            __statist_h_o_wts[4, 12] = -4.43999765367588e-001;

            __statist_h_o_wts[4, 13] = 1.83935208689346e+000;

            __statist_h_o_wts[4, 14] = -2.62449122337158e+000;

            __statist_h_o_wts[4, 15] = -3.46656788436385e-001;

            __statist_h_o_wts[4, 16] = 4.35931607670213e+000;

            __statist_h_o_wts[4, 17] = -8.51569769956495e-001;

            __statist_h_o_wts[4, 18] = 4.58870579775132e-001;

            __statist_h_o_wts[4, 19] = -2.72445182886779e+000;

            __statist_h_o_wts[4, 20] = -8.18691317549427e-001;

            __statist_h_o_wts[4, 21] = -2.44555855817647e-001;

            __statist_h_o_wts[4, 22] = -1.97997041872876e+000;

            __statist_h_o_wts[4, 23] = -8.12813624026826e-003;

            __statist_h_o_wts[4, 24] = 3.21858766005405e+000;

            __statist_h_o_wts[4, 25] = 5.76606721550028e-001;

            __statist_h_o_wts[4, 26] = -9.70166583199077e-001;

            __statist_h_o_wts[4, 27] = 7.55623127196067e-001;

            __statist_h_o_wts[4, 28] = 1.27369727209748e+000;

            __statist_h_o_wts[4, 29] = -2.45317191620711e+000;



            __statist_h_o_wts[5, 0] = 1.45713440018886e+000;

            __statist_h_o_wts[5, 1] = -1.97926102797949e+000;

            __statist_h_o_wts[5, 2] = 1.29885815975775e-001;

            __statist_h_o_wts[5, 3] = -1.41795755084655e+000;

            __statist_h_o_wts[5, 4] = 1.13070816147521e+000;

            __statist_h_o_wts[5, 5] = 5.45959245106211e-001;

            __statist_h_o_wts[5, 6] = 3.85747380134896e-001;

            __statist_h_o_wts[5, 7] = -2.02082360217800e+000;

            __statist_h_o_wts[5, 8] = 3.20011077523208e-001;

            __statist_h_o_wts[5, 9] = 8.37047010623124e-001;

            __statist_h_o_wts[5, 10] = -8.47712817188126e-001;

            __statist_h_o_wts[5, 11] = 5.86392134512466e-001;

            __statist_h_o_wts[5, 12] = -6.20370492155860e-001;

            __statist_h_o_wts[5, 13] = -7.18654415993615e-001;

            __statist_h_o_wts[5, 14] = -7.05702340451868e-001;

            __statist_h_o_wts[5, 15] = 2.29649483266245e-001;

            __statist_h_o_wts[5, 16] = 2.19437260444846e+000;

            __statist_h_o_wts[5, 17] = 1.11790114143181e+000;

            __statist_h_o_wts[5, 18] = -2.58230696595820e+000;

            __statist_h_o_wts[5, 19] = 2.77282447304042e-002;

            __statist_h_o_wts[5, 20] = -5.40641120239075e-001;

            __statist_h_o_wts[5, 21] = 8.99886388811132e-002;

            __statist_h_o_wts[5, 22] = -9.05569172951587e-001;

            __statist_h_o_wts[5, 23] = 6.90330824989894e-001;

            __statist_h_o_wts[5, 24] = 1.03832922071857e+000;

            __statist_h_o_wts[5, 25] = 3.99833436335485e-001;

            __statist_h_o_wts[5, 26] = 4.43110645022709e-001;

            __statist_h_o_wts[5, 27] = 5.89828393521083e-001;

            __statist_h_o_wts[5, 28] = -5.08377619108311e-001;

            __statist_h_o_wts[5, 29] = 1.18070868387556e-001;



            double[] __statist_hidden_bias = new double[30];

            __statist_hidden_bias[0] = 2.13696587561884e-001;

            __statist_hidden_bias[1] = 8.47428633001557e-001;

            __statist_hidden_bias[2] = -1.41758127848922e-001;

            __statist_hidden_bias[3] = -4.15589448583392e-001;

            __statist_hidden_bias[4] = 1.03663419917679e+000;

            __statist_hidden_bias[5] = 1.84404666701038e+000;

            __statist_hidden_bias[6] = 1.44300199623972e-001;

            __statist_hidden_bias[7] = 6.94882006264244e-001;

            __statist_hidden_bias[8] = 6.95467144751848e-001;

            __statist_hidden_bias[9] = 4.17084108040588e+000;

            __statist_hidden_bias[10] = 3.68052813786317e-001;

            __statist_hidden_bias[11] = -6.36797645555889e-001;

            __statist_hidden_bias[12] = 1.05111232362853e-001;

            __statist_hidden_bias[13] = 1.36116978159929e+000;

            __statist_hidden_bias[14] = -1.53155302891300e+000;

            __statist_hidden_bias[15] = -6.24944414360817e-001;

            __statist_hidden_bias[16] = 5.11670508059239e+000;

            __statist_hidden_bias[17] = -3.67918548585926e-001;

            __statist_hidden_bias[18] = 1.48705307188629e+000;

            __statist_hidden_bias[19] = -1.28823979556156e+000;

            __statist_hidden_bias[20] = -2.34195235941467e-001;

            __statist_hidden_bias[21] = -4.77096753208389e-001;

            __statist_hidden_bias[22] = -3.11459849481099e+000;

            __statist_hidden_bias[23] = -2.51275579480658e-001;

            __statist_hidden_bias[24] = 1.38451741286926e+000;

            __statist_hidden_bias[25] = 4.91730074176571e-001;

            __statist_hidden_bias[26] = -6.77849331557295e-001;

            __statist_hidden_bias[27] = 4.72097893059575e-002;

            __statist_hidden_bias[28] = 7.28196375733272e-001;

            __statist_hidden_bias[29] = -1.86239756482480e+000;



            double[] __statist_output_bias = new double[6];

            __statist_output_bias[0] = -3.93187439257763e-001;

            __statist_output_bias[1] = 2.79737792650436e+000;

            __statist_output_bias[2] = 5.43804964825005e+000;

            __statist_output_bias[3] = 2.32550981759661e+000;

            __statist_output_bias[4] = -3.97081576721741e+000;

            __statist_output_bias[5] = -6.24756242167627e+000;



            double[] __statist_inputs = new double[7];



            double[] __statist_hidden = new double[30];



            double[] __statist_outputs = new double[6];

            __statist_outputs[0] = -1.0e+307;

            __statist_outputs[1] = -1.0e+307;

            __statist_outputs[2] = -1.0e+307;

            __statist_outputs[3] = -1.0e+307;

            __statist_outputs[4] = -1.0e+307;

            __statist_outputs[5] = -1.0e+307;



            __statist_inputs[0] = Tromb_N;

            __statist_inputs[1] = PTI_N;

            __statist_inputs[2] = Fibrinogen_N;

            __statist_inputs[3] = APTV_N;

            __statist_inputs[4] = Sag_N;

            __statist_inputs[5] = FV_N;

            __statist_inputs[6] = RKFM_N;



            double __statist_delta = 0;

            double __statist_maximum = 1;

            double __statist_minimum = 0;

            int __statist_ncont_inputs = 7;



            /*scale continuous inputs*/

            for (int __statist_i = 0; __statist_i < __statist_ncont_inputs; __statist_i++)
            {

                __statist_delta = (__statist_maximum - __statist_minimum) / (__statist_max_input[__statist_i] - __statist_min_input[__statist_i]);

                __statist_inputs[__statist_i] = __statist_minimum - __statist_delta * __statist_min_input[__statist_i] + __statist_delta * __statist_inputs[__statist_i];

            }



            int __statist_ninputs = 7;

            int __statist_nhidden = 30;



            /*Compute feed forward signals from Input layer to hidden layer*/

            for (int __statist_row = 0; __statist_row < __statist_nhidden; __statist_row++)
            {

                __statist_hidden[__statist_row] = 0.0;

                for (int __statist_col = 0; __statist_col < __statist_ninputs; __statist_col++)
                {

                    __statist_hidden[__statist_row] = __statist_hidden[__statist_row] + (__statist_i_h_wts[__statist_row, __statist_col] * __statist_inputs[__statist_col]);

                }

                __statist_hidden[__statist_row] = __statist_hidden[__statist_row] + __statist_hidden_bias[__statist_row];

            }



            for (int __statist_row = 0; __statist_row < __statist_nhidden; __statist_row++)
            {

                if (__statist_hidden[__statist_row] > 100.0)
                {

                    __statist_hidden[__statist_row] = 1.0;

                }

                else
                {

                    if (__statist_hidden[__statist_row] < -100.0)
                    {

                        __statist_hidden[__statist_row] = -1.0;

                    }

                    else
                    {

                        __statist_hidden[__statist_row] = Math.Tanh(__statist_hidden[__statist_row]);

                    }

                }

            }



            int __statist_noutputs = 6;



            /*Compute feed forward signals from hidden layer to output layer*/

            for (int __statist_row2 = 0; __statist_row2 < __statist_noutputs; __statist_row2++)
            {

                __statist_outputs[__statist_row2] = 0.0;

                for (int __statist_col2 = 0; __statist_col2 < __statist_nhidden; __statist_col2++)
                {

                    __statist_outputs[__statist_row2] = __statist_outputs[__statist_row2] + (__statist_h_o_wts[__statist_row2, __statist_col2] * __statist_hidden[__statist_col2]);

                }

                __statist_outputs[__statist_row2] = __statist_outputs[__statist_row2] + __statist_output_bias[__statist_row2];

            }





            double __statist_sum = 0.0;

            double __statist_maxIndex = 0;

            for (int __statist_jj = 0; __statist_jj < __statist_noutputs; __statist_jj++)
            {

                if (__statist_outputs[__statist_jj] > 200)
                {

                    double __statist_max = __statist_outputs[1];

                    __statist_maxIndex = 0;

                    for (int __statist_ii = 0; __statist_ii < __statist_noutputs; __statist_ii++)
                    {

                        if (__statist_outputs[__statist_ii] > __statist_max)
                        {

                            __statist_max = __statist_outputs[__statist_ii];

                            __statist_maxIndex = __statist_ii;

                        }

                    }



                    for (int __statist_kk = 0; __statist_kk < __statist_noutputs; __statist_kk++)
                    {

                        if (__statist_kk == __statist_maxIndex)
                        {

                            __statist_outputs[__statist_jj] = 1.0;

                        }

                        else
                        {

                            __statist_outputs[__statist_kk] = 0.0;

                        }

                    }

                }

                else
                {

                    __statist_outputs[__statist_jj] = Math.Exp(__statist_outputs[__statist_jj]);

                    __statist_sum = __statist_sum + __statist_outputs[__statist_jj];

                }

            }

            for (int __statist_ll = 0; __statist_ll < __statist_noutputs; __statist_ll++)
            {

                if (__statist_sum != 0)
                {

                    __statist_outputs[__statist_ll] = __statist_outputs[__statist_ll] / __statist_sum;

                }

            }



            int __statist_PredIndex = 1;

            for (int __statist_ii = 0; __statist_ii < __statist_noutputs; __statist_ii++)
            {

                if (__statist_ConfLevel < __statist_outputs[__statist_ii])
                {

                    __statist_ConfLevel = __statist_outputs[__statist_ii];

                    __statist_PredIndex = __statist_ii;

                }

            }



            __statist_PredCat = __statist_DCats[__statist_PredIndex];



            return __statist_PredCat;


        }

      }
    }
    