﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lock-screen.aspx.cs" Inherits="WebRedDS.authentication.lock_screen" %>

<!DOCTYPE html>
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

<body class="bg-lock-screen">
	<!-- wrapper -->
	<div class="wrapper">
		<div class="authentication-lock-screen d-flex align-items-center justify-content-center">
			<div class="card shadow-none bg-transparent">
				<div class="card-body p-md-5 text-center">
					<h2 class="text-white">10:53 AM</h2>
					<h5 class="text-white">Tuesday, January 14, 2021</h5>
					<div class="">
						<img src="../librerias/images/icons/user.png" class="mt-5" width="120" alt="" />
					</div>
					<p class="mt-2 text-white">Administrator</p>
					<div class="mb-3 mt-3">
						<input type="password" class="form-control" placeholder="Password" />
					</div>
					<div class="d-grid">
						<button type="button" class="btn btn-white">Login</button>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- end wrapper -->
</body>

</html>