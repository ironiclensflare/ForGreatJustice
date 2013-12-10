<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ForGreatJustice.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crime!</title>
    <link rel="stylesheet" type="text/css" href="css/main.css" />
    <script src="js/jquery-1.10.2.min.js"></script>
    <script src="js/search.js"></script>
</head>
<body>
    <div id="container" class="clearfix">
        <h1>Crimes in <asp:Literal ID="place" runat="server"></asp:Literal></h1>
        <asp:Literal ID="mainContent" runat="server"></asp:Literal>
        <form id="search">
            <input type="text" size="10" name="search" />
            <input type="submit" value="Submit" />
            <span>Powered by Google</span>
        </form>
    </div>
    <p class="copyright">Crime data provided by <a href="http://data.police.uk" title="">data.police.uk</a>. Images by <a href="https://developers.google.com/maps/" title="Google Street View">Google Street View</a>.</p>
</body>
</html>
