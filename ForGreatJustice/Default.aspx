﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ForGreatJustice.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crime!</title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body>
    <div id="container" class="clearfix">
        <h1>Crimes that have happened</h1>
        <asp:Literal ID="mainContent" runat="server"></asp:Literal>
    </div>
    <p class="copyright">Crime data provided by <a href="http://data.police.uk" title="">data.police.uk</a>. Images by <a href="https://developers.google.com/maps/" title="Google Street View">Google Street View</a>.</p>
</body>
</html>
