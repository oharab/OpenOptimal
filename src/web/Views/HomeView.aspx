<%@ Page
Language           = "C#"
Inherits           = "OpenRasta.Codecs.WebForms.ResourceView<HomeResource>"
Title			   = "Bob"
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
<div class="hero-unit">
<h1><%= Resource.Title %></h1>
<p>This is a prototype website to record and manage the cocoon visits carried out under Operation Optimal.</p>
<p><a class="btn btn-primary btn-large" href="<%= typeof(NewCocoonResource).CreateUri()%>">Add new cocoon &raquo;</a></p>
</div>
<h2>Outstanding Supercocoons</h2>
<asp:Repeater Id="OutstandingCocoonsRepeater" Runat="server" DataSource=<%# Resource.OutstandingSuperCocoons %>>
	<HeaderTemplate>
	<div class="row-fluid">
	</HeaderTemplate>
	<FooterTemplate></div></FooterTemplate>
	<ItemTemplate>
	<div class="span4">
		<h3><%#((SuperCocoonResource)Container.DataItem).CrimeReference%></h3>
		<a href="<%#((SuperCocoonResource)Container.DataItem).CreateUri()%>">Enter</a>
	</div>
	</ItemTemplate>
</asp:Repeater>

</asp:Content> 
