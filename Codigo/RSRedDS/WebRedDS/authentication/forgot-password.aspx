<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot-password.aspx.cs" Inherits="WebRedDS.authentication.forgot_password" %>

<html lang="en">

<head>
	<!-- Required meta tags -->
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<!--favicon-->
	<link rel="icon" href="../librerias/images/favicon-32x32.png" type="image/png" />
	<!-- loader-->
	<link href="../librerias/css/pace.min.css" rel="stylesheet" />
	<script src="../librerias/js/pace.min.js"></script>
	<!-- Bootstrap CSS -->
	<link href="../librerias/css/bootstrap.min.css" rel="stylesheet">
	<link href="../librerias/css/app.css" rel="stylesheet">
	<link href="../librerias/css/icons.css" rel="stylesheet">
	<title>Syndron - Bootstrap5 Admin Template</title>
</head>

<body class="bg-forgot">
	<!-- wrapper -->
	<div class="wrapper">
		<div class="authentication-forgot d-flex align-items-center justify-content-center">
			<div class="card forgot-box">
				<div class="card-body">
					<div class="p-4 rounded  border">
						<div class="text-center">
							<img src="../librerias/images/icons/forgot-2.png" width="120" alt="" />
						</div>
						<h4 class="mt-5 font-weight-bold">Forgot Password?</h4>
						<p class="text-muted">Enter your registered email ID to reset the password</p>
						<div class="my-4">
							<label class="form-label">Email id</label>
							<input type="text" class="form-control form-control-lg" placeholder="example@user.com" />
						</div>
						<div class="d-grid gap-2">
							<button type="button" class="btn btn-primary btn-lg">Send</button> <a href="signin.aspx" class="btn btn-light btn-lg"><i class='bx bx-arrow-back me-1'></i>Back to Login</a>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- end wrapper -->
</body>

</html>