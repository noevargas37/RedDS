﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteIN.Master" AutoEventWireup="true" CodeBehind="component-progress-bars.aspx.cs" Inherits="WebRedDS.component_progress_bars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contentenedor" runat="server">
    <!--start page wrapper -->
		<div class="page-wrapper">
			<div class="page-content">
				<!--breadcrumb-->
				<div class="page-breadcrumb d-none d-sm-flex align-items-center mb-3">
					<div class="breadcrumb-title pe-3">Components</div>
					<div class="ps-3">
						<nav aria-label="breadcrumb">
							<ol class="breadcrumb mb-0 p-0">
								<li class="breadcrumb-item"><a href="javascript:;"><i class="bx bx-home-alt"></i></a>
								</li>
								<li class="breadcrumb-item active" aria-current="page">Progress Bars</li>
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
					<div class="col col-lg-9 mx-auto">
						<div class="card">
							<div class="card-body">
								<div class="card-title">
									<h5 class="mb-0">Basic progress bars</h5>
								</div>
								<hr>
								<div class="progress mb-4 h-7">
									<div class="progress-bar" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress mb-4 h-7">
									<div class="progress-bar w-25" role="progressbar" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress mb-4 h-7">
									<div class="progress-bar w-50" role="progressbar" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress mb-4 h-7">
									<div class="progress-bar w-25" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress h-7">
									<div class="progress-bar w-100" role="progressbar" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
							</div>
							<div class="card-body">
								<div class="card-title">
									<h5 class="mb-0">Labels</h5>
								</div>
								<hr>
								<div class="progress">
									<div class="progress-bar w-25" role="progressbar" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">25%</div>
								</div>
							</div>
							<div class="card-body">
								<div class="card-title">
									<h5 class="mb-0">Backgrounds</h5>
								</div>
								<hr>
								<div class="progress mb-3 h-7">
									<div class="progress-bar bg-success w-25" role="progressbar" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress mb-3 h-7">
									<div class="progress-bar bg-info w-50" role="progressbar" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress mb-3 h-7">
									<div class="progress-bar bg-warning w-75" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress mb-3 h-7">
									<div class="progress-bar bg-danger w-100" role="progressbar" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
							</div>
							<div class="card-body">
								<div class="card-title">
									<h5 class="mb-0">Multiple bars</h5>
								</div>
								<hr>
								<div class="progress h-7">
									<div class="progress-bar w-25" role="progressbar" aria-valuenow="15" aria-valuemin="0" aria-valuemax="100"></div>
									<div class="progress-bar bg-successr w-50" role="progressbar" aria-valuenow="30" aria-valuemin="0" aria-valuemax="100"></div>
									<div class="progress-bar bg-infor w-25" role="progressbar" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
							</div>
							<div class="card-body">
								<div class="card-title">
									<h5 class="mb-0">Striped</h5>
								</div>
								<hr>
								<div class="progress mb-3 h-7">
									<div class="progress-bar progress-bar-striped w-25" role="progressbar" aria-valuenow="10" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress mb-3 h-7">
									<div class="progress-bar progress-bar-striped bg-success w-25" role="progressbar" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress mb-3 h-7">
									<div class="progress-bar progress-bar-striped bg-info w-50" role="progressbar" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress mb-3 h-7">
									<div class="progress-bar progress-bar-striped bg-warning w-25" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
								<div class="progress h-7">
									<div class="progress-bar progress-bar-striped bg-danger w-25" role="progressbar" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
							</div>
							<div class="card-body">
								<div class="card-title">
									<h5 class="mb-0">Animated stripes</h5>
								</div>
								<hr>
								<div class="progress h-7">
									<div class="progress-bar progress-bar-striped progress-bar-animated w-75" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100"></div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		<!--end page wrapper -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScripts" runat="server">
</asp:Content>
