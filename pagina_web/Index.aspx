<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="pagina_web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

         <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="description" content="">
        <meta name="author" content="">

        <title>Inicio de sesion </title>

        <!-- Bootstrap Core CSS -->
       <!--  <link href="../css/bootstrap.min.css" rel="stylesheet">-->

        <link href="Content/bootstrap.css" rel="stylesheet"/>
        
        <link href="Content/sb-admin-2.css" rel="stylesheet"/>

        <link href="Content/all.min.css" rel="stylesheet"/>
     
         <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/>

        <!-- MetisMenu CSS -->
        <link href="../css/metisMenu.min.css" rel="stylesheet"/>

        <!-- Custom CSS -->
        <link href="../css/startmin.css" rel="stylesheet"/>

        <!-- Custom Fonts -->
        <link href="../css/font-awesome.min.css" rel="stylesheet" type="text/css" />

        <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
        <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/html5shiv/3.7.3/html5shiv.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/respond.js/1.4.2/respond.min.js"></script>
        <![endif]-->
</head>
<body class="bg-gradient-light">

        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <div class="login-panel panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title text-center">Inicio de sesión</h3>
                        </div>
                        <div class="panel-body">
                            <form class="user" runat="server" >
                              <div class="form-group">
                                  <asp:TextBox class="form-control form-control-user" ID="TextBox1" runat="server" placeholder="Usuario"  ></asp:TextBox> 
                              </div>
                              <div class="form-group">
                                  <asp:TextBox class="form-control form-control-user" placeholder="Contraseña"  ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                               <asp:Button class="btn btn-color btn-user btn-block" ID="Btn_ingresar" runat="server" Text="Ingresar" OnClick="Btn_ingresar_Click" Visible="True" /> 
                           </form>   

                        </div>
                    </div>
                </div>
            </div>
        </div>
            <!-- jQuery -->
        <script src="../js/jquery.min.js"></script>

        <script src="Content/bootstrap.bundle.min.js"></script>

        <script src="Content/jquery.easing.min.js"></script>

        <!-- Bootstrap Core JavaScript -->
        <script src="../js/bootstrap.min.js"></script>

        <!-- Metis Menu Plugin JavaScript -->
        <script src="../js/metisMenu.min.js"></script>

        <!-- Custom Theme JavaScript -->
        <script src="../js/startmin.js"></script>
</body>
</html>
