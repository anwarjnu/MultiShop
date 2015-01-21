<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_Products" Codebehind="FeaturedProducts.ascx.cs" %>
<script src="<%# Page.ResolveClientUrl("~/Resources/FeaturedProducts/jscript_jquery-1.4.min.js") %>"></script>
<script src="<%# Page.ResolveClientUrl("~/Resources/FeaturedProducts/jscript_xjcarousellite.js") %>"></script>
<script src="<%# Page.ResolveClientUrl("~/Resources/FeaturedProducts/jscript_zcoin-slider.js") %>"></script>
<script type="text/javascript">
    $(function () {
        $(".carousel").jCarouselLite({
            btnNext: ".next",
            btnPrev: ".prev"
        });
    });
</script>
<asp:Panel ID="Panel1" runat="server" CssClass=" FeaturedProductContainer">
    <a href="#" class="prev"></a><a href="#" class="next"></a>
    <div class="carousel">
        <ul>
            <asp:Repeater ID="RepeaterProduct" runat="server">
                <ItemTemplate>
                    <li>
                        <div>
                            <asp:HyperLink ID="lnkProductImage" Target="_parent" NavigateUrl='<%# String.Concat("~/Pages/Other/ProductDetails.aspx?ProductId=",Eval("ProductID")) %>'
                                runat="server">
                                <asp:Image ID="Image1" AlternateText='<%#Eval("ProductName")%>' ImageUrl='<%# String.Concat("~/Resources/Images/Thumb/",Eval("ImageName")) %>'
                                    runat="server" />
                            </asp:HyperLink>
                        </div>
                        <div>
                            <span class="priceTag ProductTag"">
                                <%# String.Concat(" ", Eval("ProductName"))%>
                            </span>

                        </div>
                        <div>
                            <span class="priceTag">
                                Tk <%# String.Concat(" ", Eval("OurPrice"))%>
                            </span>
                        </div>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Panel>

