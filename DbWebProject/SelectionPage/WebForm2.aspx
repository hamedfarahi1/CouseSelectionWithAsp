<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DbWebProject.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    	<title>Course Selection</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/perfect-scrollbar/perfect-scrollbar.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css"/>
	<link rel="stylesheet" type="text/css" href="css/main.css"/>
    <link rel="stylesheet" href="css1/style.css"/>
<!--===============================================================================================-->
</head>
<body>
    <form id="form1" runat="server">
    <div class="limiter">
        
		<div class="container-table100">
			<div class="wrap-table100">
				<div class="table100">
                    <div id="Div4" runat="server" >

                        <asp:Button ID="Button1" runat="server" Text="Back To Options" CssClass="login100-form-btn" OnClick="Button1_Click"/>
                    </div>
                    <div id="Div1" runat="server" style="margin-top:50px">
                         <div class="col">
  <div class="container-1">
    <div class="btn btn-one">
 <asp:Button ID="Button6" runat="server" Text="Courses" onClick="Button6_Click" class="login100-form-btn"/>

    </div>
  </div>

  <div class="container-2">
    <div class="btn btn-two">
      <span>Courses Of Your Department</span>
    </div>
  </div>

  <div class="container-3">
    <div class="btn btn-three">
      <asp:Button ID="Button7" runat="server" Text="Marks" onClick="Button7_Click" class="login100-form-btn"/>
    </div>
  </div>
</div>

<div class="col">
  <div class="container-4">
    <div class="btn btn-two">
      <span>Marks of Student</span>
    </div>
  </div>

  <div class="container-5">
    <div class="btn btn-five">
      <asp:Button ID="Button8" runat="server" Text="Logout " onClick="Button8_Click" class="login100-form-btn"/>
    </div>
  </div>

  <div class="container-6">
    <div class="btn btn-two">
      <span>Go to Login Page</span>
    </div>
  </div>
</div>

                    </div>

                    <div style="margin-top:50px" id="Div2" runat="server">
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="login100-form-btn" OnSelectedIndexChanged="checkList_Handler" AutoPostBack="true">
                            <asp:ListItem>BIO-101</asp:ListItem>
                            <asp:ListItem>BIO-301</asp:ListItem>
                            <asp:ListItem>BIO-399</asp:ListItem>
                            <asp:ListItem>CS-101</asp:ListItem>
                            <asp:ListItem>CS-190</asp:ListItem>
                            <asp:ListItem>CS-315</asp:ListItem>
                            <asp:ListItem>CS-319</asp:ListItem>
                            <asp:ListItem>CS-347</asp:ListItem>
                            <asp:ListItem>EE-181</asp:ListItem>
                            <asp:ListItem>FIN-201</asp:ListItem>
                            <asp:ListItem>HIS-351</asp:ListItem>
                            <asp:ListItem>MU-199</asp:ListItem>
                            <asp:ListItem>PHY-101</asp:ListItem>

                    </asp:DropDownList>
                    </div>
                    <div id="Div3" runat="server" style="margin-top:50px">

                        <asp:Button ID="Button9" runat="server" Text="Submit" CssClass="login100-form-btn" OnClick="Button9_Click"/>
                    </div>
                 
				</div>
			</div>
		</div>
        </div>


	

<!--===============================================================================================-->	
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>  

    </form>
</body>
</html>
