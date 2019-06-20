﻿<%@ Page Title="Log in to Planet Wrox" Language="C#" MasterPageFile="~/MasterPages/Frontend.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <h1>Log in to Planet Wrox</h1>
    <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
            <asp:Login ID="Login1" runat="server" CreateUserText="Sign Up for a New Account at Planet Wrox" CreateUserUrl="~/SignUp.aspx" DestinationPageUrl="~/Default.aspx">
            </asp:Login><br /><br />
            <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
                <MailDefinition Subject="Your New Password For PlanetWrox.com"></MailDefinition>
            </asp:PasswordRecovery>
        </AnonymousTemplate>
        <LoggedInTemplate>
            You are already logged in.
        </LoggedInTemplate>
    </asp:LoginView>
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
</asp:Content>
