## ChatGPT C# API

OpenAI ChatGPT 的逆向工程SDK。可扩展用于聊天机器人等。觉得不错请右上角Star  
感谢 revChatGPT.以及ChatGPT Java Api https://github.com/PlexPt/chatgpt-java  

![](https://avatars.githubusercontent.com/u/14957082?s=200&v=4)

## 如何使用
### 1.创建一个会话
```
OpenAISession openAIOptions = new OpenAISession(Session_token, CfClearance, UserAgent);
await openAIOptions.RefreshSessionAsync();
```
如何获取Session_token，CfClearance，UserAgent？
1. 通过 https://chat.openai.com/chat 注册并登录。
2. 打开浏览器开发者工具，切换到 Application 标签页。
3. 在左侧的 Storage - Cookies 中找到 __Secure-next-auth.session-token 一行并复制其值
4. 找到 cf_clearance 复制
5. 在network中获取 user-agent 复制

注意：如果提示403. 请检查以上参数是否正确，是否过期。并且获取以上参数的浏览器要和本程序在同一IP地址

### 2.创建一个机器人
```
Chatbot chatbot = new Chatbot(openAIOptions);
```
### 3.聊天
```
await chatbot.GetChatReplyAsync("xxx");
```
## 如何注册ChatGPT 代码简介，用户隔离，上下文聊天
查看博客