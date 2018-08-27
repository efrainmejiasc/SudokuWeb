<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaySudoku.aspx.cs" Inherits="SudokuWeb.View.PaySudoku" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script src="https://www.paypalobjects.com/api/checkout.js"></script>
    <title>Sudoku Para Todos</title>
    <link rel="shortcut icon" href="~/public/images/SudokuEnCasa.ico" />
    <script>
  paypal.Button.render({
  env: 'sandbox',
  client: {
    sandbox: 'demo_sandbox_client_id'
  },
  payment: function (data, actions) {
    return actions.payment.create({
      transactions: [{
        amount: {
          total: '0.01',
          currency: 'USD'
        }
      }]
    });
  },
  onAuthorize: function (data, actions) {
    return actions.payment.execute()
      .then(function () {
        window.alert('Thank you for your purchase!');
      });
  }
}, '#paypal-button');
</script>
</head>
<body>
    <form id="form1" runat="server">
       <div id="paypal-button"></div>
    </form>
</body>
</html>
