<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_SideMenu" Codebehind="SideMenu.ascx.cs" %>

<script type='text/javascript'>new Sys.WebForms.Menu({ element: 'topContentInfo1_mnuSignUp', disappearAfter: 500, orientation: 'horizontal', tabIndex: 0, disabled: false });
</script>
<script type='text/javascript'>    new Sys.WebForms.Menu({ element: 'topLink_menuTop', disappearAfter: 500, orientation: 'horizontal', tabIndex: 0, disabled: false });
</script>
<script type='text/javascript'>    new Sys.WebForms.Menu({ element: 'MenuProduct', disappearAfter: 500, orientation: 'vertical', tabIndex: 0, disabled: false });
</script>

<div id="leftMenu">
    <div class="menu" id="MenuProduct">
        <ul class="level1">
            <li>
                <asp:HyperLink runat="server" ID="menu1" class="level2" NavigateUrl="~/Default.aspx">Shirts</asp:HyperLink></li>
            <li>
                <asp:HyperLink runat="server" ID="menu2" class="level2" NavigateUrl="~/Default.aspx">T-shirts</asp:HyperLink></li>
            <li>
                <asp:HyperLink runat="server" ID="menu4" class="level2" NavigateUrl="~/Default.aspx">Electronics</asp:HyperLink></li>
            <li>
                <asp:HyperLink runat="server" ID="menu7" class="level2" NavigateUrl="~/Default.aspx">Computer Accessories</asp:HyperLink></li>
            <li>
                <asp:HyperLink runat="server" ID="menu8" class="level2" NavigateUrl="~/Default.aspx">Body Spray & Perfume</asp:HyperLink></li>
            <li>
                <asp:HyperLink runat="server" ID="menu10" class="level2" NavigateUrl="~/Default.aspx">Audio Devices</asp:HyperLink></li>
            <li>
                <asp:HyperLink runat="server" ID="menu11" class="level2" NavigateUrl="~/Default.aspx">Gift Item</asp:HyperLink></li>
            <li>
                <asp:HyperLink runat="server" ID="menu12" class="level2" NavigateUrl="~/Default.aspx">Mobile</asp:HyperLink></li>
            <li>
                <asp:HyperLink runat="server" ID="menu13" class="level2" NavigateUrl="~/Default.aspx">Mobile Accessories</asp:HyperLink></li>
            <li>
                <asp:HyperLink runat="server" ID="menu14" class="level2" NavigateUrl="~/Default.aspx">Watch</asp:HyperLink></li>
            <li>
                <asp:HyperLink runat="server" ID="menu16" class="level2" NavigateUrl="~/Default.aspx">Others</asp:HyperLink></li>
        </ul>
    </div>
</div>
