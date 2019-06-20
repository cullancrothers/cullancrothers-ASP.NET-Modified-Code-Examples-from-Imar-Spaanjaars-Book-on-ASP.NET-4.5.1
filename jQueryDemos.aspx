<%@ Page Title="jQuery Demos" Language="C#" MasterPageFile="~/MasterPages/Frontend.master" AutoEventWireup="true" CodeFile="jQueryDemos.aspx.cs" Inherits="Demos_jQueryDemos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="Server">
  <h1 title="First Header">First Header</h1>
  <table id="DemoTable">
    <tr>
      <td>Row 1 Cell 1</td>
      <td>Row 1 Cell 2</td>
    </tr>
    <tr>
      <td>Row 2 Cell 1</td>
      <td>Row 2 Cell 2</td>
    </tr>
    <tr>
      <td>Row 3 Cell 1</td>
      <td>Row 3 Cell 2</td>
    </tr>
    <tr>
      <td>Row 4 Cell 1</td>
      <td>Row 4 Cell 2</td>
    </tr>
    <tr>
      <td>Row 5 Cell 1</td>
      <td>Row 5 Cell 2</td>
    </tr>
  </table>
  <h2>Second <span style="font-style: italic; font-weight: bold;">Header</span></h2>
  <input id="Button1" type="button" value="button" />
  <input id="Text1" type="text" />
  <input id="Checkbox1" type="checkbox" />
  <input id="Checkbox2" type="checkbox" />
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="cpClientScript">
  <script>
    $(function ()
    {
        // Examples go here
        //$('#DemoTable tr:first').css('background-color', 'red');
        //$('#DemoTable tr:last').css('background-color', 'red');
        //$('#DemoTable tr:odd').css('background-color', 'red');
        //$('#DemoTable tr:even').css('background-color', 'red');
        //$('#DemoTable tr:eq(0)').css('background-color', 'green');
        //$('#DemoTable tr:gt(2)').css('background-color', 'green');
        //$('#DemoTable tr:lt(2)').css('background-color', 'green');
        //$(':header').css('background-color', 'green');
        //$('td:contains("Row 3")').css('color', 'green');
        //$(':header:has("span")').css('color', 'green');
        //$('input[type]').css('color', 'green');
        //$('[type=text]').css('color', 'red');
        //$(':button, :text').css('color', 'red');
        //$(':checkbox').attr('checked', 'true');
        //$('h1').css('background-color', 'green');
        //alert($('h2 span').css('font-style')); 
        //$('#DemoTable td').css({ 'color': 'red', 'font-family': 'Verdana', 'padding': '10px' });
        //$('h2').addClass('PleaseWait');
        //$('h2').removeClass('PleaseWait');
        //alert($('h1').attr('title'));
        /*$('#DemoTable tr').bind('mouseover',
            function ()
            {
                $(this).css('background-color', 'yellow')
            }
            ).bind('mouseout',
            function ()
            {
                $(this).css('background-color', '')
            }
            );*/
        /*$('#DemoTable td').each(function () { alert(this.innerHTML);});*/
        //alert($('#DemoTable td:contains("Row 1 Cell 2") ').prev()[0].innerHTML);
        //alert($('#DemoTable td:contains("Row 1 Cell 2") ').parent()[0].innerHTML);
        //$('h1').hide(1000);
        //$('h1').show(1000);
        //$('h1').toggle(2000);
        //$('h1').slideUp(1000);
        //$('h1').slideDown(1000);
        //$('h1').slideToggle(1000);
        //$('h1').fadeOut(1000);
        //$('h1').fadeIn(1000);
        //$('h1').fadeTo(1000, 0.5);
        $('h1').animate({ opacity: 0.4, marginLeft: '50px', fontSize: '50px' }, 1500);
    });
  </script>
</asp:Content>
