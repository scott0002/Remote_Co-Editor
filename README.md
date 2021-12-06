# Remote_Co-Editor
This project is for socket programming of "Computer Networking" Class.

## GitHub link
https://github.com/scott0002/Remote_Co-Editor

## Tech Stack
### Language
C#
### Framework
Windows Presentation Foundation (WPF)
### Implementation Details
#### core function - co-editor
When client's text changed, then update to server. When server's text changed or receive update, then update to all clients. In this manner, co-editor can serve more than two users. 
#### Create Host (server)
Server-side socket programming
#### Connect Host (client)
Client-side socket programming
#### Check Status
Maintain UserList in server-side, and update to clients when new client connect to server.

## Features
### core function - co-editor
Multiple users connected, they can edit same text at the same time.

### Create Host (server)
Input IP and Port, then click "create". 
Server will be created, and you can check connection status in "check status" feature.

### Connect Host (client)
Input IP and Port you want to connect, then click "connect". 
Client will connect to Server, and you can check connection status in "check status" feature.

### Check Status
Open it, you will see server's IP and Port, and all clients' IP and Port. 
Besides, click "Reload" can update this status to check whether there is new client connection.

### Disconnection
Clear connection.

## Issue track
1. https://stackoverflow.com/questions/15636047/image-in-wpf-button-not-visible-at-runtime
2. https://stackoverflow.com/questions/9732709/the-calling-thread-cannot-access-this-object-because-a-different-thread-owns-it

## Reference
1. https://www.gemboxsoftware.com/document/examples/word-editor-wpf/5203
2. https://github.com/GemBoxLtd/GemBox.Document.Examples
3. https://www.itread01.com/content/1550006300.html
4. https://docs.microsoft.com/en-us/answers/questions/514638/how-to-trigger-a-text-changed-event-of-a-wpf-rich.html
5. https://medium.com/delightlearner/c-development-%E5%A6%82%E4%BD%95%E5%BF%AB%E9%80%9F%E5%BB%BA%E7%AB%8B-tcp-ip-%E9%80%A3%E7%B7%9A%E4%B8%A6%E5%82%B3%E9%80%81%E8%B3%87%E6%96%99-ad28d0f01520
6. https://github.com/tsai1247/SocketChatroom_for_Windows
