<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="TD2.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <style>
        /*body{
            border: 5px solid cadetblue;
            height: 212px;
        }*/
        .txtCenter{
            text-align:center;
        }
        .btn{
            margin:5px;
        }
        
        #btn {
            background-color:lightblue;
            height: 300px;
            width: 259px;
        }
        #Button1{
            Margin-left:125px;
        }
    </style>
</head>
<body style="width: 263px; height: 362px">
    <form id="form1" runat="server">
        <div id="txtbox">
            <asp:TextBox ID="TextBox1" runat="server" Height="53px" Width="254px"></asp:TextBox>
        </div>
        <div id="btn" class="conteneur txtCenter">
            <asp:Label ID="Label1" runat="server" CssClass="btn"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="C" Width="45px" cssClass="btn" Height="45px" OnClick="Button1_Click" /><br />
            <span><asp:Button ID="Button2" runat="server" Text="7" Width="45px" cssClass="btn" Height="45px" OnClick="Button2_Click" /></span> 
            <span><asp:Button ID="Button3" runat="server" Text="8" Width="45px" cssClass="btn" Height="45px" OnClick="Button3_Click" /></span> 
            <span><asp:Button ID="Button4" runat="server" Text="9" Width="45px" cssClass="btn" Height="45px" OnClick="Button4_Click" /></span> 
            <span><asp:Button ID="Button5" runat="server" Text="+" Width="45px" cssClass="btn" Height="45px" OnClick="Button5_Click" /></span> 
            <span><asp:Button ID="Button6" runat="server" Text="4" Width="45px" cssClass="btn" Height="45px" OnClick="Button6_Click" /></span> 
            <span><asp:Button ID="Button7" runat="server" Text="5" Width="45px" cssClass="btn" Height="45px" OnClick="Button7_Click" /></span> 
            <span><asp:Button ID="Button8" runat="server" Text="6" Width="45px" cssClass="btn" Height="45px" OnClick="Button8_Click" /></span> 
            <span><asp:Button ID="Button9" runat="server" Text="-" Width="45px" cssClass="btn" Height="45px" OnClick="Button9_Click" /></span> 
            <span><asp:Button ID="Button10" runat="server" Text="1" Width="45px" cssClass="btn" Height="45px" OnClick="Button10_Click" /></span> 
            <span><asp:Button ID="Button11" runat="server" Text="2" Width="45px" cssClass="btn" Height="45px" OnClick="Button11_Click" /></span> 
            <span><asp:Button ID="Button12" runat="server" Text="3" Width="45px" cssClass="btn" Height="45px" OnClick="Button12_Click" /></span> 
            <span><asp:Button ID="Button13" runat="server" Text="/" Width="45px" cssClass="btn" Height="45px" OnClick="Button13_Click" /></span> 
            <span><asp:Button ID="Button14" runat="server" Text="0" Width="45px" cssClass="btn" Height="45px" OnClick="Button14_Click" /></span> 
            <span><asp:Button ID="Button15" runat="server" Text="," Width="45px" cssClass="btn" Height="45px" OnClick="Button15_Click" /></span> 
            <span><asp:Button ID="Button16" runat="server" Text="=" Width="45px" cssClass="btn" Height="45px" OnClick="Button16_Click" /></span> </span> 
            <span><asp:Button ID="Button17" runat="server" Text="*" Width="45px" cssClass="btn" Height="45px" OnClick="Button17_Click" /></span> 
        </div>
    </form>
</body>
</html>
