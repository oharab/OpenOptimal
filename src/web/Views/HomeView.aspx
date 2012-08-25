<%@ Page
Language           = "C#"
Inherits           = "OpenRasta.Codecs.WebForms.ResourceView<HomeResource>"
Title			   = "Bob"
MasterPageFile	   = "~/Views/Shared/Bootstrap-Fluid.master"	
%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server"> 
<div class="hero-unit">
<h1><%= Resource.Title %></h1>
<p>This is a prototype website to record and manage the cocoon visits carried out under Operation Optimal.</p>
<p><a class="btn btn-primary btn-large" href="#">Add new cocoon &raquo;</a></p>
</div>
</asp:Content> 

