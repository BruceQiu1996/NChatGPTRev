using NChatGPTRev;

namespace NChatGTPRev.Start
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36 Edg/108.0.1462.46";
            var CfClearance = "E3X07VcmUUNZcW7hdqV_maOYoPPTU0vra_.Ev5BagoY-1670984005-0-1-4575ca9c.e2f265ae.19ebcccc-160";
            var Session_token = "eyJhbGciOiJkaXIiLCJlbmMiOiJBMjU2R0NNIn0..Bw-mkEx5xAaVyhSd.GpePg2tZGThKrpSRv64pLCycvu6p8Xjd82__ghhO7PkyRIeNDkeNK3xMpHwlx2AJgOeR7XvVL6nHzsJnXbb0dU0v5D_kwA2iUPw-nuCBPEBicsYhQbJjYkR3CDmA7PGoNnzUa8Li4LMcS7dtNQNPu6TSyuZHHmfkKQVv9ZiXri2EsvFWpxTKFMdFGEWp1TsldHRSO73_lPnu-yfe7_sS8Stxl7D2ByUefU9-Ihh_ezHSgx5Ix_f235DKSqZ3hnqsGy_t0EN5j7Ov3sojFt9uonzYLzoGPOHdd2uAwghkyUGR5nI5whj5ZvSoZOmETllaYIK9JcRhVRE9NU8Ye0yyxeI6FfPJpxB4-SsYmm8Eb_MgpoIZq_dwuYIqUg0Sf-qBmUNmu4a5kVv5df5kUWId5YN3EQoOO_hod4HPOI7Ta8l7td9oWtgRZTJhiPjrUWFqeV6Orwi6mqK0FJX-Bikms8PYUo28qbPDfof-v10WFQwZKdRyrRkFWYxcp6ryx3NEfs0ceZ6wwjNwJ7ivG3Wo6Gg8xhT2cHMLqE_gzgPnhPphA9OWazc8Z_7XTnug_-yTJOBroJZor82JV0jLPHgX19s13OrchdYupQs0z186lA_BNbzihx4QJ0kt_fuInNHbMfeW6rKjaA1xpiIfGP6HarhSFq9_fSxQGbK79CFQzaedxBZnFRbZ4NBxBndjvHszmmAGP5QCUHS5kktbMulTOckIw35v8ub7hOjnEJTgCAUj5j1DwVi-NR9AIHON_1cw8LKXtxVmROkVNTyoDdrCLW3-OGiXMb6KbjUgaF-1erji_WYwW45VhC9dnndbqHWEwKtyPZC2kDpakAZWT5DF3VmxYyDwtQPKgoEqqilRpe_60QIro2ORjuRXg163Qb9p2kjOzb5yPtCNmqPG79ItyfIMfbph2CSCgNHSOMwGSda3QnykG19AKZ9bWdvCn87N4Bj8_gBrKlwB5oNqhYoNE312LuF3O3YyOE9tgNR3PP8yeuJfh2waNXY4pOT_rBWdzvmK_5JRr7mVHJkR8PxLzGzs3IWXfFQ_O1bRjBmJ9J4MdG0PepxmZL_lZACheh4tNTXAHzIVaDk_6Vw-HC1iQQRBLSlA5IpaEckTtnfiGjHDEe_laNzrFH1JTVW9vG1u5hUmulm3wzI2fqAUB-QWlyF0LF9_9Xrif4vwy1WvdbloRSi1ICdgO0CC-Tk8zZeDBA0D30A46AxzSA4m2GtLuVTxbxAgAVWYexeUcGyDlAjAPlfvawSGLF4N-MO6yMr5WflseocSNtA3tffzRtHG39yu843DOOxtJe_2G0ORqLWj0Xz6ZodAqoQHk61drsvdjph_vtwW5gCYKNei9QOK8G9Yb_36J-hahcAcXa4BvS4hBz0CD-ES6ul7dUT2w8jxMeasaKH0hwIhNubHEhRzo90emyy_5AWMMiFDL_i1jgidR1trPwOeHsZUs-3ENf4rlKIJJRzXHcc9PrWvgkqCCDr8EpTyw-7TPZ-63nTIH9R1dVMann9jni1rSKKifi8VnZQBznlzni6dbjjhyJwkXugx2-J8bA3LCm6InPL44m65_kT5sTpOv6Y9SsmW3_aV3OW7jXfn9AdBeXfQWjwTgYxwN7WodlydzQNsHFVyAB6vkkbwFUo1o5s-iYi9-_r-ggMTMO9A6Ic5H2HaNn-YAZvk1WFGMQEgL-sCEG5qJ_-Kl6lvb_DW48USJ905K6_Qau1ZPUtWweVCHQA0qBOz5Zrv4dbYLbJF9XgEaHq1uUarpD63nPuYuKj3GqS2yk-pJ8Lv5-jYjDwNFUOrIY3rglg2f5EbGGmChcSs2u04KXzBF6VYxnCrCc2WS4Rp62qA1gCJWY2AMG5MzVWypfTbif6tzpnhLfg4PPKXkp6yoHZQbmw8cm_RwUM59mGz2_y9vUQQWHsUSM_H-LNIS5GZeJcW-kBCNKklPw73aYW_5ZKm-CnGfMLhJ8dYOb99ayXDOuJv9sXe8v2jPqWJvDFDguyaxjZAhjCQFHzJv_3Y0ZgGaIvBpziAKJ3sVhPH72YeFfyJqae6AxgSujCmtEq_h4-GEOENsX8bYjl9tra84S6Ypmeu4fo32jXNLx_GdAb7y9yZKyy75iL3-jauKIkf3F5C1FRJwNu0OJns_nL6NjuUNmEhlitqt65Z2h0ibia4r03037LNmKym-rGxhbk1X9N95L_dXPWq_NkzuVIQ8teYUj5Sq0FKGBXyE1pu832LD6Q3HrXq-Eq4oc02MvYeTbBcgJc4VA8I4Tq8mce-CJzT-iqInlktfIZenlYslsWnwfoyF2jOT8Thnj1PFOvZwh6q3qqAnwlsug.BVMDU0JEI15dEoX-YRErLg";
            OpenAISession openAIOptions = new OpenAISession(Session_token, CfClearance, UserAgent);
            await openAIOptions.RefreshSessionAsync();


            Chatbot chatbot = new Chatbot(openAIOptions);
            Console.WriteLine("用c++写个冒泡查询");
            var reply = await chatbot.GetChatReplyAsync("用c++写个冒泡查询");
            Console.WriteLine(reply.Message.Content.Parts.FirstOrDefault());
        }
    }
}