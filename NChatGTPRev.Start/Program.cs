using NChatGPTRev;

namespace NChatGTPRev.Start
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36 Edg/108.0.1462.46";
            var CfClearance = "yGeVnmMPh35AfxoifVRF9pLf9tGUcBhmsiYyn.DNp68-1670945868-0-1-7b5f7aa.2d0a300a.11b47560-160";
            var Session_token = "eyJhbGciOiJkaXIiLCJlbmMiOiJBMjU2R0NNIn0..H4r8dw7YA9SaFipa.qN8HX7RJeORPBYsO04xCdLqC5FAnOGguVIYN4VMARBNGiN7E_g1PO1UDZt9KV3h7DLo4sP6zP927EXZeNicK-4znhc-PC0X8FdMOPuLIE9T9hEEI2fAwRmi8v-bd1Cma1eNxAG7PHxbaZYORHN5zcuVs1Tpk8qWxxQb-oMe3kK4QiSuyLPxBaErgY84mJHYdtpU2yegQLj5L0hqWko0guRtbDrg4JtY4ZqRfy2cscReZUqg-GBEKRY1I0ckt9jvKf2EOKMsC2DYEbV3GgU7kpIdYbmdnaJ5pO9k8ap5DtV8hIVh32euQ_cR2RqMJKO9lKoiHIU8UDeU9enCaIwE_bnhldb1aiV4lpeNSw87gl4SsCGJlAaZWgsO2JHl_ZY_oVXGTPVBCMe1UYiPZP3Suyzh9GeJgVn7Fj_UyRybYzlVDjI_Qhp5HrXC1XWnO5hNAq2F5JQWHsAMQSynNSywB3_H_yWpmiJqsr4zq7f00l_Fp6UBOX4W8J2rochWC_95kKsYe1po_LCWx2QLxIw4nUE0rpOWtbXeg9dnUMcDhS1x_YYjD4wI7QAtOVSZrxLF4rdjYk9H2ORW4uPeLRMY4WXv3j2Zhb5zu9a-nfLpWKO6OztRFMzuIOneyKVw9xXf7h_jN3Yxy3plCfSMosq_OxbOk2pAuLK-5bxXe8E_lRktRiJZmUTd0GVh3KGkTqV0QIc156P5KpbmC6K9W_Wr4kWRb7P4FYfoFCjeTxk-S0kA0cBD66t8SEvVjs0IoRsPpEE8pM9QwF81SMHDP-kg4WJKGSqXctPHiSV0INpPOtXqw45mdreOI_eEzVn36yJ3fLzGnm93tdA_Lkk2W2tpwHyj5ARryMka-OzyRs3UuFHE-KwgEAJ5zx1jXMaW12jUClttk2jccYds4BuuKb4gT8pIA1T7nRnp6Zqz4b0-uCElen6sf_pKR2tvFDJMLCQFRIKO8PwsV8DAZXo-4r5UJJw5hmCNjhVTXJioWScl1EENqsn2rqiEdegp7PObfr8rvYBe9ZLA63fZRYGRs0Vx54BLpMmc_u3-tVfR3iIrQ7Yy59huJkopLKB-ho3PYrPe0b_Oz56uH_7iABVQeb5Wni5z7S8LgAdzlm-LSwNgmtyvlLqWwrvQkUJQLZcQ9I92O6Lw96wC3ppEtnv6Q_b5daBdmprrijD1ShKQAcf0IK4lAUyww2usQ8IX8en5PDfQZNcn0rQEgPEtn5nzJ4TDzL5_vgvmFiF7OV2JRaL9c5A8VqWAAvIVxUHpzA_XyrfJ1CbtOJHQFaIHy4fxyRLutIjKsrP8GofmlZ20vPRqC5Up4sOha8oTpZMS6ZXJPNq7HYX3dx5izRadkni5L4RxLLTd2bejZGCtthBXkEhfirKVKV2F9hny4y14WNrKB7GdHrEVE-5z_PI9b04b8JrbCsqy9hWE7HaBaFo9Rv9yPwf3tz1axyvcTJYbv1dHt0OLfXuZGFBIPc2sd_oNIBawONvLETVyZzL9184NF-tglD8Y-Axbifr3XBYVtoTNViW-e64gXjO2eSucU4nB6125BQWweu6CsAWYAW2Au4CY_oymrexerVrwZbpWJSaFKNXlF0kV8FOJ6kRdhw8JpaZ1TcUPvgFQPUxVkQclsNyoZzVBhq2eNrMMUxy-YX_Fj-73V80eob0yYGzIu19Rk572up3DYcKdNhCHaI8SAIHStS-hi7s_4gn1IzdFa0fjNJ0JagXjboMnR-iuQGP-2IMKiXoqTb9FrvxqGFPOhqlWx_RCA1Yiq--y2EUzlMVc_z23Dgm1j982Cuh2ccmWEjgki4J-Ja1HXIgVBOG3GVtsCPGq_HCnUJDidWLKMs65Le8tgOVfkaYt4mU1-VM3WyyW7gxzuiFP85P7gmwqLvGXZIiamYO30uYp7HLxGcq7SfMwm3aQ0T_QfVnZ0IezQvKRrw6jVPts7sytXI7vqZ24L4XsOEGXeHWxEbnxjf55sbUoKkG80j73t2m975OCZUfAb05neRyN5R4PzS-iK5BjJyaxs4AeoI3xbllCtmGuuG09i4OCgPxsXNn9FOH2Hkp40rI9vFOBMh0oDANmbO6JyGUhD1XGlVybQC4bN-i6K5aXt8cQahN6SLRvnuOmdUxJ590TLmGZl1l1c_Mrc5pLJwzq8p9TYyJkDeNYmp7TWNHdOO18qHSXuNi7dUfs4NU4D7hmNwu9DsgZw-_0p7qD3k7ev0fKAcJEUPlbAtfJxL391s1_O1CSEIqJLaWMB-_J8lGRJivEVIo5iqjFI6naDnyxYZinqSZkQkdJvPY-0qrALZPV2CzOc8KySqsTBs-xokixyd0DRVOToXg.yKS0q61qSpGxGfI2rpQkCQ";
            OpenAISession openAIOptions = new OpenAISession(Session_token, CfClearance, UserAgent);
            await openAIOptions.RefreshSessionAsync();


            Chatbot chatbot = new Chatbot(openAIOptions);
            Console.WriteLine("用c++写个冒泡查询");
            var reply = await chatbot.GetChatReplyAsync("用c++写个冒泡查询");
            Console.WriteLine(reply.Message.Content.Parts.FirstOrDefault());

            await Task.Delay(10000);
            Console.WriteLine("再用java写一个");
            var reply1 = await chatbot.GetChatReplyAsync("再用java写一个");
            Console.WriteLine(reply1.Message.Content.Parts.FirstOrDefault());
        }
    }
}