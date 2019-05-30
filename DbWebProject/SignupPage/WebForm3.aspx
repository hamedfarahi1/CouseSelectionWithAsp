<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="DbWebProject.SignupPage.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Register Forms for Taking Semsters</title>
     <!-- Required meta tags-->
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content="Colorlib Templates"/>
    <meta name="author" content="Colorlib"/>
    <meta name="keywords" content="Colorlib Templates"/>

    <!-- Title Page-->

    <!-- Icons font CSS-->
    <link href="vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all"/>
    <link href="vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all"/>
    <!-- Font special for pages-->
    <link href="https://fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/>

    <!-- Vendor CSS-->
    <link href="vendor/select2/select2.min.css" rel="stylesheet" media="all"/>
    <link href="vendor/datepicker/daterangepicker.css" rel="stylesheet" media="all"/>

    <!-- Main CSS-->
    <link href="css/main.css" rel="stylesheet" media="all"/>
    <style>
        input-group {
  position: relative;
  margin-bottom: 22px;
}
.input-group .tooltiptext {
  visibility: hidden;
  width: 125px;
  background-color: black;
  color: #fff;
  text-align: center;
  padding: 5px 0;
  border-radius: 6px;
 
  /* Position the tooltip text - see examples below! */
  
  z-index: 1;
}

/* Show the tooltip text when you mouse over the tooltip container */
.input-group:hover .tooltiptext {
  visibility: visible;
}
    </style>
</head>
<body>
   
    <div class="page-wrapper bg-gra-02 p-t-130 p-b-100 font-poppins">
        <div class="wrapper wrapper--w680">
            <div class="card card-4">
                <div class="card-body">
                    <h2 class="title">Registration Form</h2>
                    <form id="form1" runat="server" method="POST">
                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">first name</label>
                                    <asp:TextBox ID="firstName" runat="server" class="input--style-4" type="text" name="Name"></asp:TextBox>
                                    
                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Password</label>
                                    <asp:TextBox ID="passwordBox" runat="server" class="input--style-4" type="password" name="password"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Birthday</label>
                                    <div class="input-group-icon">
                                        <asp:TextBox ID="birthday" runat="server" class="input--style-4 js-datepicker" type="text" name="birthday"></asp:TextBox>
                                        <i class="zmdi zmdi-calendar-note input-icon js-btn-calendar"></i>
                                    </div>
                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Gender</label>
                                    <div class="p-t-10">
                                        <label class="radio-container m-r-45">Male
                                            <asp:TextBox ID="mGender" runat="server" type="radio" checked="checked" name="gender"></asp:TextBox>
                                            <span class="checkmark"></span>
                                        </label>
                                        <label class="radio-container">Female
                                            <asp:TextBox ID="fGender" runat="server" type="radio" name="gender"></asp:TextBox>
                                            <span class="checkmark"></span>
                                        </label>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                    <span class="tooltiptext">Comp. Sci. , History , Finance , Physics , Music , Elec. Eng. , Biology</span>
                                    <label class="label">Departman</label>
                                    <asp:TextBox ID="depatmanBox" runat="server" class="input--style-4" type="text" name="Departman"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Phone Number</label>
                                    <asp:TextBox ID="phoneNumber" runat="server" class="input--style-4" type="text" name="phone" ></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="input-group">
                            <label class="label">Subject</label>
                            <div class="rs-select2 js-select-simple select--no-search">
                                <select name="subject">
                                    <option disabled="disabled" selected="selected">Choose option</option>
                                    <option>Register For Taking Semsters</option>
                                </select>
                                <div class="select-dropdown"></div>
                            </div>
                        </div>
                        <div class="p-t-15">
                            <asp:Button ID="Button1" runat="server" Text="Submit" class="btn btn--radius-2 btn--blue" type="submit" OnClick="SubmitButton_Click"/>
                        </div>
                        <div class="p-t-15">
                            <asp:Button ID="Button3" runat="server" Text="Back To Login" class="btn btn--radius-2 btn--blue" type="submit" OnClick="SubmitButton_Click2"/>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <!-- Jquery JS-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <!-- Vendor JS-->
    <script src="vendor/select2/select2.min.js"></script>
    <script src="vendor/datepicker/moment.min.js"></script>
    <script src="vendor/datepicker/daterangepicker.js"></script>

    <!-- Main JS-->
    <script src="js/global.js"></script>
</body>
</html>
