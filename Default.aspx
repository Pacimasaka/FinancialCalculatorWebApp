<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinancialCalculatorWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row mt-4">
             <section id="calculatorSection">
                <h2>Financial Calculator</h2>
        
                <label for="ddlCalculation">Select Calculation:</label>
                <asp:DropDownList ID="ddlCalculation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCalculation_SelectedIndexChanged">
                    <asp:ListItem Text="Select Calculation Type" Value="Select"></asp:ListItem>
                    <asp:ListItem Text="Calculate Simple Interest" Value="SimpleInterest"></asp:ListItem>
                    <asp:ListItem Text="Calculate Principal" Value="Principal"></asp:ListItem>
                    <asp:ListItem Text="Calculate Rate" Value="Rate"></asp:ListItem>
                    <asp:ListItem Text="Calculate Time" Value="Time"></asp:ListItem>
                </asp:DropDownList>
        
                 <div id="divPrincipal" runat="server">
                    <label for="txtPrincipal">Principal Amount:</label>
                    <asp:TextBox ID="txtPrincipal" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                 </div>
                 <div id="divSimpleInterest" runat="server">
                    <label for="txtInterest">SimpleInterest:</label>
                    <asp:TextBox ID="txtInterest" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                </div>

                <div id="divRate" runat="server">
                    <label for="txtRate">Rate:</label>
                    <asp:TextBox ID="txtRate" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                </div>

                <div id="divTime" runat="server">
                    <label for="txtTime">Time(Days):</label>
                    <asp:TextBox ID="txtTime" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                </div>

                <asp:Button ID="btnCalculate" runat="server" CssClass="btn btn-secondary mt-4" Text="Calculate" OnClick="btnCalculate_Click" />
        
                <br />

                <asp:Label ID="lblResult" runat="server" Visible="false" style="color: green;"></asp:Label>
            </section>
      </div>
    </main>

</asp:Content>
