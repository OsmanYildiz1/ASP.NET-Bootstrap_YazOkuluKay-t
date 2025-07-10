<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <head>
        <link rel="stylesheet" href="StyleSheet.css" />
    </head>
    <form id="Form1" runat="server">

        <div class="form-group">
            <div class="bosluk">
                <asp:Label for="TxtId" runat="server" Text="Öğrenci ID:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div class="bosluk">
                <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="bosluk">
                <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="bosluk">
                <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numarası:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="bosluk">
                <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="bosluk">
                <asp:Label for="TxtFoto" runat="server" Text="Öğrenci Fotoğraf:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="btn1">
                <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" style="width:150px;" />
            </div>
        </div>


    </form>
</asp:Content>
