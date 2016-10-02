<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list_webform.aspx.cs" Inherits="WebApp_jQuery.list_webform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>jQuery Add / Remove Table Rows Dynamically</title>
    <link rel="stylesheet" href="css/DynamicRow.css" />
    <script type="text/javascript" src="http://code.jquery.com/jquery.min.js"></script>
    <script type="text/javascript" src="Scripts/addandrow.js">    
    </script>
</head>
<body>
    <form id="form1" method="post" runat="server">
        <div>
            <input type="text" id="name" placeholder="Name"><asp:Label ID="errname" runat="server" >&nbsp;&nbsp;</asp:Label><br /><br />
            <input type="text" id="email" placeholder="Email Address"><asp:Label ID="erremail" runat="server">&nbsp;&nbsp;</asp:Label><br /><br />
            <input type="button" class="add-row" value="Add Row" onclick="addrow()">
        </div>
        <div>
            <table>
                <thead>
                    <tr>
                        <th>Select</th>
                        <th>Name</th>
                        <th>Email</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <input type="checkbox" name="record"></td>
                        <td>Sushil Kumar</td>
                        <td>sushilclass@mail.com</td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div>

            <button type="button" class="delete-row" onclick="deleterow()">Delete Row</button>
        </div>
    </form>
</body>
</html>
