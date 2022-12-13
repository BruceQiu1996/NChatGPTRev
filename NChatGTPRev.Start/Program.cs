using NChatGPTRev;

namespace NChatGTPRev.Start
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36 Edg/108.0.1462.46";
            var CfClearance = "5EKJx.mkcW6C4KM48TKJ7.OMPlWKWXMxIh.h9eLLQGs-1670938477-0-1-7b5f7aa.2d0a300a.11b47560-160";
            var Session_token = "eyJhbGciOiJkaXIiLCJlbmMiOiJBMjU2R0NNIn0..d2vf_bEzyNdKoF-6.--W1bBXnP08q3LakwjG623OjyGoCKm4LPN6nDV-0KqgQP4MuQ7AbwngIOxAihk_fn5a_yejwSvJZGWjlUG7ah3FPrjX5nqRl_9wq9dZQ1hiPVYZGEQecuQH8c_rv-KWlufXjxMrMs3n9K38EcujBybhWC3F6aC2RlYOK1in9laGsL_G6wUztXkOMZPzK7GYm0honj1d99tkdpwnWJrFstJB-on3U2k4OYY8l6mopXCPp_Fq2bB8JgZcpgVKsm6qw6-KoGHclp_oBTjD8Va8fZIULjYx5cbKTxucf-2yxDtJWxNCJyWUr-QedjoE1zltApMQaPGr-0MmcZHk5ptDQXd94zZTX5_brhXyjlnbJo5rnBr5eWUtvQi1QyN7iGKkW70oWlMTo0uqwxHnv-75wCAPZvdzjcS9akLgZnB013PuI60DXmySOQK1Dd_lboQzu-nwPfUaGSCDdtO9KDUIOh12ncoFy_XG02d3xquAx7aAc_iF7X8HOlmEZIBW2M11Cmuyu_5pcNyxMDmoE-l9tJ3mSI1GAzqEJEgzizbF0E_3ADNiPX4AdtO34RzETuiePKBoj4U3WobkdtxY9yU7jhg9bRem3t1eKOdMMxmbFI4PQz802fwhOaZeJ1xhSuWWhSBpFfkxD--9iDqYJoCPnvVGKS9lcdADs7suycKaA-BgPxYLI8QW9wU-7BZiX0ZkvnlJGMIRNW1EQ2j4xRDuwophWh0yIgR2SlXM0NH4-Fn631n_WMuZ1qSSZhrjVrKUZ4btCea2n6-D-V9vO2HqO1YtA3kqI_vCjG7wGp1LmvW1q38jiMOm8xiX3z8OpUwh1b0AycmHgTUXeWo3-T0k1xph7evnhKiliznKtol6JBZE1YtpEoE6gBzQkXw-zasKntALL-qSfKS832oys204jq6wo4CnWCeelh-L-2ZmTu0nGuCO0_Smvc31rDSIfTO1yNpLo67Kv8KTAEnYZe905iQsTxDXLrC5PmFOAxMmHWPLoqCAv5YEPMtLs8x-TISlCXFMEUGDK6uTY-xEHxbRNcXfPLpLDt6py5u5qF1PKIfQMonWPSGrY2-xyDTG6gGeoTnsn7EEb_336ipp9rZ-iAIpOqalnrVi8l_Rt8a_oSz42qqtd0OGeX83NZCVVu7prfUdy_wMrxbvUqnYYPQQdnFpXvTcfKX_4l7KxBVTsxunkC-YM_39yMmhCZySn8UmmmUjPNWNVpyhJfwL4BOf_f3JKqZmA0l0mEBZtHvEnNZtDUaCLI8FUISs7yuDCGiCpt5Jtom2kNSQyX-rp6gydrPZQN07xFOAVU5XecJ2aFLTBHAiq_H2lmMgaOqjfh1oGQaR3pdjR2po0KSnl0wmsTJzk1QmuAW-ljflV2rk74uycUkH_c5C_FyoTeQ4SBsiA91sVlrAQjQAZIPAzzvgstJfFPICBiTCrI9BgF9LOH3JJrb7Ir84NYwVYUBW2NH3utVYImyU4YseMrNjCsXTkgI-ojSIWJiHhpWTjATN6CW2j9Tv03uOYUVCWdW3VjwqnUDulhDuhBIPtRUk-hepQk60uXxaUjduOESLleIHryXS-0USaHFRHjbvtfg-0-zl0a2VquV_KBOWfkJC8h1aicYMaG9hTJ3jXBR6qxwPKCbIj1I4J3W0u6h6B80MNsb2VZfiFEcEGpVPeGJdJDdDxvgnxGffLgsCQz99bHeNzLFUlZQ-q6PIvtshzDMIGsXi5QgJ60Idmm7ADwMC2YSje_r7sIaHTqIjbCV5KAyWd2DP8VWdetHKGKATf6fDItgpnzXPUVdZOjpPhmkQVJ3gefIdAZZhOxquNzQAfb3gp6pn9UFgs2mMDXBHuCtEgkF9UGn-COtjSg0-93ycpfVjed6P0fyyqfZo2pjCt8aSaXeWaydVf28trhPIiUzlXTjp94x_iL59ZPcFOtEw1ThfeFKjJUpvGV2sZFjuBldvNxXJjUTaOdzHPtpCkadbRFXVIyKtRviKw1kqsHjOvKv2hXOhGJrUJmSlZCrsd3n1dUWdXNJJanf3KFxi_NB4UBPzhto6dYPspt8-DssA2JHRnPaQs7_mPYRqJHRcqhK3o-mChlkeQ5A_SVF7Py2Gymo2yA_jPHCHKgrQ4GD_QohENCoDafQ7iiNoymWSfYC4k4eLYAHa4eKGjCYCjPhfIDrc2HUiQqSyLFHkitMZsomJbEtkmkXselKrK2LjfZ8NULniTrrtVSneedQus1KTvf3XGYa7jMgt1aGHaGE6CRsxJs5H3vnxiea_2H-2IYaJT6MdbwNJ_QfKIgycL-lVHf71WHc0fD5GyIInzCikdfqVRr4xi9XCIKKK1WA.Rmh2eYlCDTV7ov_qB6qA0Q";
            OpenAISession openAIOptions = new OpenAISession(Session_token, CfClearance, UserAgent);
            await openAIOptions.RefreshSessionAsync();
            Chatbot chatbot = new Chatbot(openAIOptions);
            var replay = await chatbot.GetChatReplyAsync("你是谁");
            var replay3 = await chatbot.GetChatReplyAsync("你是谁");

            chatbot.ResetConversation();
            var replay4 = await chatbot.GetChatReplyAsync("你是谁");

            OpenAISession openAIOptions1 = new OpenAISession(Session_token, CfClearance, UserAgent);
            await openAIOptions1.RefreshSessionAsync();
            Chatbot chatbot1 = new Chatbot(openAIOptions1);
            var replay1 = await chatbot1.GetChatReplyAsync("你是谁");

            var replay2 = await chatbot.GetChatReplyAsync("你是谁");
        }
    }
}