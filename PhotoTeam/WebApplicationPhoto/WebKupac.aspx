<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebKupac.aspx.cs" Inherits="WebApplicationPhoto.WebKupac" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br /><br />
    <h3 class="text-primary text-center" style="font-size:3rem">DOBRO DOŠLI! OVDE MOZETE PORUČITI PROIZVODE!
        </h3>
    <br /><br />
        <div class="container bg-primary" style="padding:50px;color:black">
            <div class="row">
                <div class="col-md-6">
                    <asp:Label ID="Label2" runat="server" Text="Lista dostupnih proizvoda"  style="color:white;font-size:2rem;margin-left:20px;"></asp:Label><br/><br/>
                    <asp:ListBox ID="ListBoxProizvodiWeb" runat="server" Height="189px" Width="424px" OnSelectedIndexChanged="ListBoxProizvodiWeb_SelectedIndexChanged"></asp:ListBox>
                        <br/>
        


                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Sifra" style="color:white"></asp:Label>  <asp:TextBox ID="TextBoxSifraProizvoda" runat="server">0</asp:TextBox><br /><br />
                   
              
       <asp:Button ID="ButtonDodaj" runat="server" Text="Dodaj u korpu" style="width:150px;margin-left:40px" OnClick="ButtonDodaj_Click"/>
                </div>

                <div class="col-md-6">
                    <asp:Label ID="Label8" runat="server" Text="Korpa" style="color:white;font-size:2rem;margin-left:100px;"></asp:Label><br/><br/>
                    <asp:ListBox ID="ListBox_Korpa" runat="server" Height="124px" Width="295px"></asp:ListBox>
                    <asp:Button ID="Button_Ocisti" runat="server" Text="Očisti korpu" OnClick="Button_Ocisti_Click" style="margin-left:10px;" />
                    <br /><br /><br />
                    <asp:Label ID="Label3" runat="server" Text="Ime" style="color:white"></asp:Label>          <asp:TextBox ID="TextBox_Ime" runat="server" style="margin-left:53px"></asp:TextBox>   <br />   <br />  
                    <asp:Label ID="Label4" runat="server" Text="Prezime" style="color:white"></asp:Label>      <asp:TextBox ID="TextBox_Prezime" runat="server" style="margin-left:24px"></asp:TextBox>  <br />   <br />  
                    <asp:Label ID="Label5" runat="server" Text="Email" style="color:white"></asp:Label>        <asp:TextBox ID="TextBox_Email" runat="server" style="margin-left:41px"></asp:TextBox><br />   <br />  
                    <asp:Label ID="Label6" runat="server" Text="Adresa" style="color:white"></asp:Label>       <asp:TextBox ID="TextBox_Adresa" runat="server" style="margin-left:31px"></asp:TextBox><br />   <br />  
                    <asp:Label ID="Label7" runat="server" Text="Broj telefona" style="color:white"></asp:Label><asp:TextBox ID="TextBox_BrTelefona" runat="server" style="margin-left:3px"></asp:TextBox><br />  <br />   
                     <br />
                 
                    <asp:Button ID="Button_Poruci" runat="server" Text="Poruči" style="width:150px;margin-left:60px" OnClick="Button_Poruci_Click"/>
                </div>

        </div>

    </div>

</asp:Content>
