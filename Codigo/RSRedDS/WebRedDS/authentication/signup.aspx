<%@ Page Title="" Language="C#" MasterPageFile="~/SiteOUT.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="WebRedDS.login.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
							<div class="card-body">
								<div class="border p-4 rounded">
									<div class="text-center">
										<h3 class="">Registro</h3>
										<p>Ya tiene una cuenta? <a href="signin.aspx">Ingresa</a>
										</p>
									</div>
<%--									<div class="d-grid">
										<a class="btn my-4 shadow-sm btn-white" href="javascript:;"> <span class="d-flex justify-content-center align-items-center">
                          <img class="me-2" src="../librerias/images/icons/search.svg" width="16" alt="Image Description">
                          <span>Sign Up with Google</span>
											</span>
										</a> <a href="javascript:;" class="btn btn-facebook"><i class="bx bxl-facebook"></i>Sign Up with Facebook</a>
									</div>
									<div class="login-separater text-center mb-4"> <span>OR SIGN UP WITH EMAIL</span>--%>
										<hr/>
									</div>
									<div class="form-body">
										<form class="row g-3">
											<div class="col-sm-6">
												<label for="inputFirstName" class="form-label">Nombre</label>
												<input type="email" class="form-control" id="inputFirstName" placeholder="Ingresa Nombre">
											</div>
											<div class="col-sm-6">
												<label for="inputLastName" class="form-label">Apellido</label>
												<input type="email" class="form-control" id="inputLastName" placeholder="Ingresa Apellido">
											</div>
											<div class="col-12">
												<label for="inputEmailAddress" class="form-label">Correo Electronico</label>
												<input type="email" class="form-control" id="inputEmailAddress" placeholder="correo@servidor.com">
											</div>
											<div class="col-12">
												<label for="inputChoosePassword" class="form-label">Password</label>
												<div class="input-group" id="show_hide_password">
													<input type="password" class="form-control border-end-0" id="inputChoosePassword" value="" placeholder="Ingresa Password"> <a href="javascript:;" class="input-group-text bg-transparent"><i class='bx bx-hide'></i></a>
												</div>
											</div>
										<%--	<div class="col-12">
												<label for="inputSelectCountry" class="form-label">Country</label>
												<select class="form-select" id="inputSelectCountry" aria-label="Default select example">
													<option selected>India</option>
													<option value="1">United Kingdom</option>
													<option value="2">America</option>
													<option value="3">Dubai</option>
												</select>
											</div>--%>
											<div class="col-12">
												<div class="form-check form-switch">
													<input class="form-check-input" type="checkbox" id="flexSwitchCheckChecked">
													<label class="form-check-label" for="flexSwitchCheckChecked">Estoy de acuerdo con los términos y condiciones</label>
												</div>
											</div>
											<div class="col-12">
												<div class="d-grid">
													<button type="submit" class="btn btn-primary"><i class='bx bx-user'></i>Registrarse</button>
												</div>
											</div>
										</form>
									</div>
								</div>
							</div>
						</div>
</asp:Content>
