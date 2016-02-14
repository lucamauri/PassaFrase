<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/templates/basic.master" CodeBehind="tecnica.aspx.vb" Inherits="PassaFrase.tecnica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHWorker" runat="server">
    <div class="genericcontainer">
        <div class="centered60pc">
            <h1>TED</h1>
            <p>Una interessante discussione a proposito delle password in questo <em><a href="http://go.ted.com/CkSK">TED Talk</a></em>.</p>
            <iframe src="https://embed-ssl.ted.com/talks/lorrie_faith_cranor_what_s_wrong_with_your_pa_w0rd.html" width="854" height="480" seamless="seamless" frameborder="0" scrolling="no" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
            <p>Ecco un estratto del discorso che riguarda le <em>Passphrase</em> cone introdotte dal fumetto XKCD:</p>
            <blockquote cite="http://www.ted.com/talks/lorrie_faith_cranor_what_s_wrong_with_your_pa_w0rd/transcript?language=en">
                So what we found in this study was that, surprisingly, pass phrases were not actually all that good. People were not really better at remembering the pass phrases than these random passwords, and because the pass phrases are longer, they took longer to type and people made more errors while typing them in. So it's not really a clear win for pass phrases. Sorry, all of you xkcd fans. On the other hand, we did find that pronounceable passwords worked surprisingly well, and so we actually are doing some more research to see if we can make that approach work even better.
                <footer>&ndash;&nbsp;<a href="http://www.ted.com/talks/lorrie_faith_cranor_what_s_wrong_with_your_pa_w0rd/transcript?language=en"><em>What’s wrong with your pa$$w0rd?</em> transcript</a></footer>
            </blockquote>
        </div>
    </div>
</asp:Content>
