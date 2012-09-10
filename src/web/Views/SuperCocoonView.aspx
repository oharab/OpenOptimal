<%@ Page
Language           = "C#"
Inherits           = "OpenRasta.Codecs.WebForms.ResourceView<SuperCocoonResource>"
MasterPageFile	   = "~/Views/Shared/Bootstrap-Fluid.master"	
%>

<script runat="server">
void Page_Load(Object sender, EventArgs e) 
{ 
   Page.DataBind();
}

</script>

<asp:Content ID="Nav" ContentPlaceHolderID="SideBarNav" Runat="Server">
            <ul class="nav nav-list">
              <li class="nav-header">Navigation</li>
              <li><a href="<%= typeof(NewCocoonResource).CreateUri()%>">Add new cocoon</a></li>
              <li><a href="#">Reports</a></li>
              <li><a href="#">Help</a></li>
            </ul>
</asp:Content>


<asp:Content ID="Main" ContentPlaceHolderID="MainContent" Runat="Server"> 
<h2><%= Resource.CrimeReference %></h2>
<p><%= Resource.Address %></p>

<asp:Repeater Id="PropertyRepeater" Runat="server" DataSource=<%# Resource.Properties %>>
	<HeaderTemplate><table>
	<tr><th>Company</th><th>Address</th><th>Town</th><th>County</th><th>Postcode</th><td /></tr>
	</HeaderTemplate>
	<FooterTemplate></table></FooterTemplate>
	<ItemTemplate>
	<tr>
		<td><%#((SuperCocoonPropertyResource)Container.DataItem).Company_Organisation%></td><td><%#((SuperCocoonPropertyResource)Container.DataItem).Address%></td><td><%#((SuperCocoonPropertyResource)Container.DataItem).Town%></td><td><%#((SuperCocoonPropertyResource)Container.DataItem).County%></td><td><%#((SuperCocoonPropertyResource)Container.DataItem).PostCode%></td><td><%#((SuperCocoonPropertyResource)Container.DataItem).Id%></td>
	</tr>
	</ItemTemplate>
</asp:Repeater>
</asp:Content> 

