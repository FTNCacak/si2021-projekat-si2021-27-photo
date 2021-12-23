<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebKupac.aspx.cs" Inherits="WebApplicationPhoto.WebKupac" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <body>
    <br /><br />
    <h3 style="color:brown">DOBRO DOSLI! OVDE MOZETE PORUCITI PROIZVODE.</h3>
    <br /><br />
    <asp:ListBox ID="ListBoxProizvodiWeb" runat="server" Height="189px" Width="500px"></asp:ListBox>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Sifra"></asp:Label>  <asp:TextBox ID="TextBoxSifraProizvoda" runat="server"></asp:TextBox><br /><br />
    <asp:Label ID="Label2" runat="server" Text="Naziv"></asp:Label>  <asp:TextBox ID="TextBoxNazivProizvoda" runat="server"></asp:TextBox>
     <br />
    <br />  
       <asp:Button ID="ButtonDodaj" runat="server" Text="Dodaj" />
</body>

</asp:Content>
