using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinancialCalculatorWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //divPrincipal.Visible = true;
            //divRate.Visible = true;
            //divTime.Visible = true;
            //divSimpleInterest.Visible = false;
        }

        protected void ddlCalculation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCalculation = ddlCalculation.SelectedValue;

            // Show/hide input fields based on the selected calculation
            switch (selectedCalculation)
            {
                case "Principal":
                    divPrincipal.Visible = false;
                    divRate.Visible = true;
                    divTime.Visible = true;
                    divSimpleInterest.Visible = true;
                    break;
                case "Rate":
                    divPrincipal.Visible = true;
                    divRate.Visible = false;
                    divTime.Visible = true;
                    divSimpleInterest.Visible = true;
                    break;
                case "Time":
                    divPrincipal.Visible = true;
                    divRate.Visible = true;
                    divTime.Visible = false;
                    divSimpleInterest.Visible = true;
                    break;
                case "SimpleInterest":
                    divPrincipal.Visible = true;
                    divRate.Visible = true;
                    divTime.Visible = true;
                    divSimpleInterest.Visible = false;
                    break;
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            string selectedCalculation = ddlCalculation.SelectedValue;

            // Perform calculation based on the selected type
            string result = "";

            switch (selectedCalculation)
            {
                case "Principal":
                    result = CalculatePrincipal();
                    break;
                case "Rate":
                    result = CalculateRate();
                    break;
                case "Time":
                    result = CalculateTime();
                    break;
                case "SimpleInterest":
                    result = CalculateSimpleInterest();
                    break;
            }

            // Display the result
            lblResult.Text = $"Result: {result}"; // Format as currency
            lblResult.Visible = true;
        }

       
        private string CalculatePrincipal()
        {
            // Implement the logic for calculating Principal
            //instantiating our web service
            //FinCalcReference.FinancialCalculatorWebServiceSoapClient client = new FinCalcReference.FinancialCalculatorWebServiceSoapClient();
            LiveFinCalcRef.FinancialCalculatorWebServiceSoapClient client = new LiveFinCalcRef.FinancialCalculatorWebServiceSoapClient();
            
            // calling our web service for calculating principal
            double rate = Convert.ToDouble(txtRate.Text);
            double time = Convert.ToDouble(txtTime.Text);
            double simpleInterest = Convert.ToDouble(txtInterest.Text);
            var principal = client.CalculatePrincipal(simpleInterest, rate, time);

            return principal;
        }

        private string CalculateRate()
        {
            // Implement the logic for calculating Rate

            //instantiating our web service
            //FinCalcReference.FinancialCalculatorWebServiceSoapClient client = new FinCalcReference.FinancialCalculatorWebServiceSoapClient();
            LiveFinCalcRef.FinancialCalculatorWebServiceSoapClient client = new LiveFinCalcRef.FinancialCalculatorWebServiceSoapClient();
            double principal = Convert.ToDouble(txtPrincipal.Text);
            double time = Convert.ToDouble(txtTime.Text);
            double simpleInterest = Convert.ToDouble(txtInterest.Text);

            var rate = client.CalculateRate(principal, simpleInterest, time);
            return rate;
        }

        private string CalculateTime()
        {
            // Implement the logic for calculating Time
            //instantiating our web service
            //FinCalcReference.FinancialCalculatorWebServiceSoapClient client = new FinCalcReference.FinancialCalculatorWebServiceSoapClient();
            LiveFinCalcRef.FinancialCalculatorWebServiceSoapClient client = new LiveFinCalcRef.FinancialCalculatorWebServiceSoapClient();
            double principal = Convert.ToDouble(txtPrincipal.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            double simpleInterest = Convert.ToDouble(txtInterest.Text);

            var time = client.CalculateTime(principal, simpleInterest, rate);
            return time;
        }

        private string CalculateSimpleInterest()
        {
            // Implement the logic for calculating Simple Interest
            //instantiating our web service
            //FinCalcReference.FinancialCalculatorWebServiceSoapClient client = new FinCalcReference.FinancialCalculatorWebServiceSoapClient();
            LiveFinCalcRef.FinancialCalculatorWebServiceSoapClient client = new LiveFinCalcRef.FinancialCalculatorWebServiceSoapClient();

            double principal = Convert.ToDouble(txtPrincipal.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            double time = Convert.ToDouble(txtTime.Text);

            var simpleInterest = client.CalculateSimpleInterest(principal, rate,time);
            return simpleInterest;
        }
    }

}