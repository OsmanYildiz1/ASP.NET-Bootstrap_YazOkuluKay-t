<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dersler.aspx.cs" Inherits="Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
       <head>
       <link rel="stylesheet" href="StyleSheet.css" />
   </head>
    <form runat="Server">
        <div  class="bosluk">
            <asp:Label ID="Label1" runat="server" Text="Ders Seçin"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div  class="bosluk">
            <asp:Label ID="Label2" runat="server" Text="Oğrenci ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="btn1">
        <asp:Button ID="Button1" runat="server" Text="Ders Talep Oluştur" cssClass="btn btn-warning" OnClick="Button1_Click" style="width:150px"/>

        </div>

    </form>

</asp:Content>

