<%@ Page
Language           = "C#"
Inherits           = "OpenRasta.Codecs.WebForms.ResourceView<NewCocoonResource>"
Title			   = "Bob"
MasterPageFile	   = "~/Views/Shared/Bootstrap-Fluid.master"	
%>

<asp:Content ID="Nav" ContentPlaceHolderID="SideBarNav" Runat="Server">
            <ul class="nav nav-list">
              <li class="nav-header">Navigation</li>
              <li class="active"><a href="<%= typeof(NewCocoonResource).CreateUri()%>">Add new cocoon</a></li>
              <li><a href="#">Reports</a></li>
              <li><a href="#">Help</a></li>
            </ul>
</asp:Content>


<asp:Content ID="Main" ContentPlaceHolderID="MainContent" Runat="Server"> 
<form method="post" class="form-horizontal" action="<%= typeof(NewCocoonResource).CreateUri()%>" enctype="multipart/form-data">
	<fieldset>
		<legend>Enter new Super Cocoon Details</legend>
		<div class="control-group">
			<label class="control-label" for="crimeReference">Crime Reference</label>
			<div class="controls">
				<input type="text" class="input-xlarge" id="crimeReference" name="CrimeReference" />
			</div>
		</div>
		<div class="control-group">
			<label class="control-label" for="address">Address</label>
			<div class="controls">
				<input type="text" class="input-xlarge" id="address" name="Address" />
				<p class="help-block">Address where the burglary occurred.</p>  
			</div>
		</div>
		<div class="control-group">
			<label class="control-label" for="address">Address List</label>
			<div class="controls">
				<input type="file" class="input-file" id="addressList" name="AddressList" />
				<p class="help-block">List of addresses to super cocoon.</p>  
			</div>
		</div>
		<div class="form-actions">  
		    <input type="submit" class="btn btn-primary" value="Save" />
	    </div>  
	</fieldset>
</form>
</asp:Content> 

