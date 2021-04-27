<%@ Page Title="" Language="C#" MasterPageFile="~/SiteOUT.Master" AutoEventWireup="true" CodeBehind="errors-coming-soon.aspx.cs" Inherits="WebRedDS.errors_coming_soon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- wrapper -->
	<div class="wrapper">
		<div >
			<div class="card shadow-none bg-transparent">
				<div class="card-body text-center">
					<h1 class="display-4 mt-5">Proximamente!</h1>
					<p>Actualmente estamos trabajando duro en esta página. <br />
						Déjanos tu correo y te notificaremos cuando el contenido este disponible
					</p>
					<div class="row">
						<div class="col-12 col-lg-12 mx-auto">
								<div class="input-group input-group-lg">
									<input type="text" class="form-control" placeholder="Ingresa tu correo electrónico">
									<button class="btn btn-primary" type="button"><i class="bx bx-right-arrow-alt"></i>
									</button>
								</div>
							
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- end wrapper -->
</asp:Content>
