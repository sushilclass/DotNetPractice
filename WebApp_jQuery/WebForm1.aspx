<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp_jQuery.WebForm1" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Move Item From One List To Another List Using jQuery</title>
    <script src="Scripts/jquery-3.1.0.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            $('#btnAdd').click(function (e) {
                $('#list1 > option:selected').appendTo('#list2');
                e.preventDefault();
            });

            $('#btnAddAll').click(function (e) {
                $('#list1 > option').appendTo('#list2');
                e.preventDefault();
            });

            $('#btnRemove').click(function (e) {
                $('#list2 > option:selected').appendTo('#list1');
                e.preventDefault();
            });

            $('#btnRemoveAll').click(function (e) {
                $('#list2 > option').appendTo('#list1');
                e.preventDefault();
            });

            $("#btnSubmit").click(function () {
                var countries = [];
                $.each($("#list2 option"), function () {
                    countries.push($(this).val());
                });
              
                document.getElementById("display").innerHTML = "You have selected the country - " + countries.join(", ");
                return false;
            });

        });

       
    </script>
</head>
<body>

    <form id="form2" runat="server" method="get">
        <div>
            <table cellpadding="4" cellspacing="4" width="90%" align="center" style="border: solid 2px gray; background-color: #ADD8E6;">
                <tr>
                    <td height="10px"></td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:ListBox ID="list1" runat="server" Width="250px" Height="200px" SelectionMode="Multiple">
                            <asp:ListItem Value="India">India</asp:ListItem>
                            <asp:ListItem Value="Brazil">Brazial</asp:ListItem>
                            <asp:ListItem Value="USA">USA</asp:ListItem>
                            <asp:ListItem Value="UK">UK</asp:ListItem>
                            <asp:ListItem Value="Japan">Japan</asp:ListItem>
                            <asp:ListItem Value="Itly">Itly</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td align="center">
                        <asp:Button ID="btnAdd" Text=">" runat="server" Width="50px" /></br></br>
                        <asp:Button ID="btnAddAll" Text=">>" runat="server" Width="50px" /></br></br>
                        <asp:Button ID="btnRemove" Text="<" runat="server" Width="50px" /></br></br>
                        <asp:Button ID="btnRemoveAll" Text="<<" runat="server" Width="50px" />
                    </td>
                    <td align="center">
                        <asp:ListBox ID="list2" runat="server" Width="250px" Height="200px" SelectionMode="Multiple"></asp:ListBox></br></br>
                          <asp:Button ID="btnSubmit" runat="server"  Text="Submit" />
                    
                    </td>
                </tr>

                </tr>
                                
            </table>
            <table cellpadding="4" cellspacing="4" width="90%" align="center" style="border: solid 2px gray; background-color: #ADD8E6;">
                <tr>
                                    <td align="center" height="10px">
                                        <asp:Label ID="display" runat="server"></asp:Label>

                                    </td>
                                </tr>
            </>
        </div>
    </form>
</body>
</html>
