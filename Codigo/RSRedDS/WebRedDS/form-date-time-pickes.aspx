<%@ Page Title="" Language="C#" MasterPageFile="~/SiteIN.Master" AutoEventWireup="true" CodeBehind="form-date-time-pickes.aspx.cs" Inherits="WebRedDS.form_date_time_pickes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
		<link href="librerias/plugins/datetimepicker/css/classic.css" rel="stylesheet" />
	<link href="librerias/plugins/datetimepicker/css/classic.time.css" rel="stylesheet" />
	<link href="librerias/plugins/datetimepicker/css/classic.date.css" rel="stylesheet" />
	<link rel="stylesheet" href="librerias/plugins/bootstrap-material-datetimepicker/css/bootstrap-material-datetimepicker.min.css">
	<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contentenedor" runat="server">
    	<!--start page wrapper -->
		<div class="page-wrapper">
			<div class="page-content">
				<!--breadcrumb-->
				<div class="page-breadcrumb d-none d-sm-flex align-items-center mb-3">
					<div class="breadcrumb-title pe-3">Forms</div>
					<div class="ps-3">
						<nav aria-label="breadcrumb">
							<ol class="breadcrumb mb-0 p-0">
								<li class="breadcrumb-item"><a href="javascript:;"><i class="bx bx-home-alt"></i></a>
								</li>
								<li class="breadcrumb-item active" aria-current="page">Date Time Pickers</li>
							</ol>
						</nav>
					</div>
					<div class="ms-auto">
						<div class="btn-group">
							<button type="button" class="btn btn-primary">Settings</button>
							<button type="button" class="btn btn-primary split-bg-primary dropdown-toggle dropdown-toggle-split" data-bs-toggle="dropdown">	<span class="visually-hidden">Toggle Dropdown</span>
							</button>
							<div class="dropdown-menu dropdown-menu-right dropdown-menu-lg-end">	<a class="dropdown-item" href="javascript:;">Action</a>
								<a class="dropdown-item" href="javascript:;">Another action</a>
								<a class="dropdown-item" href="javascript:;">Something else here</a>
								<div class="dropdown-divider"></div>	<a class="dropdown-item" href="javascript:;">Separated link</a>
							</div>
						</div>
					</div>
				</div>
				<!--end breadcrumb-->
				<div class="row">
					<div class="col-xl-9 mx-auto">
						<h6 class="mb-0 text-uppercase">Date Time Pickers</h6>
						<hr/>
						<div class="card">
							<div class="card-body">
								<div class="mb-3">
									<label class="form-label">Pick a Date</label>
									<input type="text" class="form-control datepicker" />
								</div>
								<div class="">
									<label class="form-label">Time Picker</label>
									<input type="text" class="form-control timepicker" />
								</div>
							</div>
						</div>
						<h6 class="mb-0 text-uppercase">Material DatePicker</h6>
						<hr/>
						<div class="card">
							<div class="card-body">
								<div class="mb-3">
									<label class="form-label">Default Date and Time Picker</label>
									<input class="result form-control" type="text" id="date-time" placeholder="Date Picker...">
								</div>
								<div class="mb-3">
									<label class="form-label">Date Only Picker</label>
									<input class="result form-control" type="text" id="date" placeholder="Date Picker...">
								</div>
								<div class="">
									<label class="form-label">Time Only Picker</label>
									<input class="result form-control" type="text" id="time" placeholder="Date Picker...">
								</div>
							</div>
						</div>
					</div>
				</div>
				<!--end row-->
			</div>
		</div>
		<!--end page wrapper -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScripts" runat="server">
	<script src="librerias/plugins/datetimepicker/js/legacy.js"></script>
	<script src="librerias/plugins/datetimepicker/js/picker.js"></script>
	<script src="librerias/plugins/datetimepicker/js/picker.time.js"></script>
	<script src="librerias/plugins/datetimepicker/js/picker.date.js"></script>
	<script src="librerias/plugins/bootstrap-material-datetimepicker/js/moment.min.js"></script>
	<script src="librerias/plugins/bootstrap-material-datetimepicker/js/bootstrap-material-datetimepicker.min.js"></script>
	<script src="librerias/js/form-date-time-pickes.js"></script>
</asp:Content>
