<%@ Page
Language           = "C#"
Inherits           = "OpenRasta.Codecs.WebForms.ResourceView<SuperCocoonPropertyResource>"
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


</asp:Content> 

