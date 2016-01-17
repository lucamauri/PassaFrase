<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/templates/basic.master" CodeBehind="default.aspx.vb" Inherits="PassaFrase._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHWorker" runat="server">
    <div id="containerintro" class="genericcontainer">
        <div class="centered60pc">
            <div class="halfadiv">
                <object data="graphics/logo/PFLogo.svg" type="image/svg+xml">
                    <img src="graphics/logo/PFLogo.png" />
                </object>
            </div>
            <div class="halfadiv">
                <p>
                    <em>PassaFrase</em> è un tool open source che aiuta gli utenti nella generazione di <em>passphrases</em> casuali basate su dizionari italiani.
Invece di basarsi sulla complessità – di difficile memorizzazione e di facile elaborazione per un attaccante – si basa su parole comuni ragionevolmente lunghe: facili da ricordare e difficili da attaccare.
                </p>
            </div>
        </div>
    </div>

    <div id="containerworker" class="genericcontainer">
        <div class="centered60pc">
            <h2>Genera <em>passphrases</em></h2>
            <p>
                Quante parole nella frase?
            <asp:DropDownList ID="dropdownparole" runat="server">
                <asp:ListItem Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Selected="True" Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="5">5</asp:ListItem>
            </asp:DropDownList>
                <br />
                Quante frasi in totale?
            <asp:DropDownList ID="dropdownfrasi" runat="server">
                <asp:ListItem Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Selected="True" Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="5">5</asp:ListItem>
            </asp:DropDownList>
            </p>
            <asp:Button ID="BTNTest" runat="server" Text="Mostra frasi" />
            <%-- <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    
                </ContentTemplate>
            </asp:UpdatePanel>--%>

            <asp:Table ID="TableResults" CssClass="resulttable" runat="server" ToolTip="Tabella risultati"></asp:Table>
            <asp:Button ID="BTNExport" runat="server" Text="Esporta" />            
        </div>
    </div>

    








    <h1>Come funziona</h1>
    Si basa su un dizionario
    <h2>Cos'è una <em>passphrase</em></h2>
    <h2>Cosa significano i valori</h2>









</asp:Content>
