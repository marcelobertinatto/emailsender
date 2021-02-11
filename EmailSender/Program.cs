﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
       
            GmailClientInfo client = new GmailClientInfo() {
                 GmailUserEmail= "jvssbrito@gmail.com",
                 GmailUserPassword= "mwkevjfatwzqrdpg",                  
            };

            IEmailSender GmailSender = new GmailEmailSender(client);

            EmailMessage Message = new EmailMessage()
            {
                TO = new List<string>() { "marcelobertinatto@hotmail.com" },
                CC=null,
                Subject="Está equipe de traders trouxeram a melhor sala de sinais da Europa para o Brasil. Venha conhecer agora!",
                Body = "   <html>  " +
 "     <head>  " +
 "       <title></title>  " +
 "     </head>  " +
 "     <body>  " +
 "       <div class='rps_2462'>  " +
 "         <div style='background-color: #f7f7f7'>  " +
 "           <div style='background-color: #f7f7f7'>  " +
 "             <div style='margin: 0px auto; max-width: 600px'>  " +
 "               <table  " +
 "                 align='center'  " +
 "                 border='0'  " +
 "                 cellpadding='0'  " +
 "                 cellspacing='0'  " +
 "                 role='presentation'  " +
 "                 style='width: 100%'  " +
 "               >  " +
 "                 <tbody>  " +
 "                   <tr>  " +
 "                     <td  " +
 "                       style='  " +
 "                         direction: ltr;  " +
 "                         font-size: 0px;  " +
 "                         padding: 10px;  " +
 "                         padding-left: 40px;  " +
 "                         padding-right: 40px;  " +
 "                         text-align: center;  " +
 "                       '  " +
 "                     ></td>  " +
 "                   </tr>  " +
 "                 </tbody>  " +
 "               </table>  " +
 "             </div>  " +
 "             <div  " +
 "               class='x_dropShadow-1 x_mainContainer'  " +
 "               style='  " +
 "                 border: 1px solid #d9d9d9;  " +
 "                 background: white;  " +
 "                 background-color: white;  " +
 "                 margin: 0px auto;  " +
 "                 max-width: 600px;  " +
 "               '  " +
 "             >  " +
 "               <table  " +
 "                 align='center'  " +
 "                 border='0'  " +
 "                 cellpadding='0'  " +
 "                 cellspacing='0'  " +
 "                 role='presentation'  " +
 "                 style='background: white; background-color: white; width: 100%'  " +
 "               >  " +
 "                 <tbody>  " +
 "                   <tr>  " +
 "                     <td  " +
 "                       style='  " +
 "                         direction: ltr;  " +
 "                         font-size: 0px;  " +
 "                         padding: 20px 0;  " +
 "                         padding-bottom: 30px;  " +
 "                         text-align: center;  " +
 "                         background: black;  " +
 "                       '  " +
 "                     >  " +
 "                       <div style='margin: 0px auto; max-width: 600px'>  " +
 "                         <table  " +
 "                           align='center'  " +
 "                           border='0'  " +
 "                           cellpadding='0'  " +
 "                           cellspacing='0'  " +
 "                           role='presentation'  " +
 "                           style='width: 100%'  " +
 "                         >  " +
 "                           <tbody>  " +
 "                             <tr>  " +
 "                               <td  " +
 "                                 style='  " +
 "                                   direction: ltr;  " +
 "                                   font-size: 0px;  " +
 "                                   padding: 20px 0;  " +
 "                                   padding-left: 40px;  " +
 "                                   padding-right: 40px;  " +
 "                                   padding-top: 0;  " +
 "                                   text-align: center;  " +
 "                                 '  " +
 "                               >  " +
 "                                 <div  " +
 "                                   class='x_mj-column-per-100 x_mj-outlook-group-fix'  " +
 "                                   style='  " +
 "                                     font-size: 0px;  " +
 "                                     text-align: left;  " +
 "                                     direction: ltr;  " +
 "                                     display: inline-block;  " +
 "                                     vertical-align: top;  " +
 "                                     width: 100%;  " +
 "                                   '  " +
 "                                 >  " +
 "                                   <table  " +
 "                                     border='0'  " +
 "                                     cellpadding='0'  " +
 "                                     cellspacing='0'  " +
 "                                     role='presentation'  " +
 "                                     width='100%'  " +
 "                                     style='vertical-align: top'  " +
 "                                   >  " +
 "                                     <tbody>  " +
 "                                       <tr>  " +
 "                                         <td  " +
 "                                           align='center'  " +
 "                                           style='  " +
 "                                             font-size: 0px;  " +
 "                                             padding: 10px 25px;  " +
 "                                             word-break: break-word;  " +
 "                                           '  " +
 "                                         >  " +
 "                                           <table  " +
 "                                             border='0'  " +
 "                                             cellpadding='0'  " +
 "                                             cellspacing='0'  " +
 "                                             role='presentation'  " +
 "                                             style='  " +
 "                                               border-collapse: collapse;  " +
 "                                               border-spacing: 0px;  " +
 "                                             '  " +
 "                                           >  " +
 "                                             <tbody>  " +
 "                                               <tr>  " +
 "                                                 <td style='width: 120px'>  " +
 "                                                   <img  " +
 "                                                     data-imagetype='External'  " +
 "                                                     src='https://angelsignals.live/assets/img/logo.png'  " +
 "                                                     style='  " +
 "                                                       border: 0;  " +
 "                                                       display: block;  " +
 "                                                       outline: none;  " +
 "                                                       text-decoration: none;  " +
 "                                                       height: auto;  " +
 "                                                       width: 100%;  " +
 "                                                       font-size: 13px;  " +
 "                                                     '  " +
 "                                                   />  " +
 "                                                 </td>  " +
 "                                               </tr>  " +
 "                                             </tbody>  " +
 "                                           </table>  " +
 "                                         </td>  " +
 "                                       </tr>  " +
 "                                     </tbody>  " +
 "                                   </table>  " +
 "                                 </div>  " +
 "                               </td>  " +
 "                             </tr>  " +
 "                           </tbody>  " +
 "                         </table>  " +
 "                       </div>  " +
 "                       <div style='margin: 0px auto; max-width: 600px'>  " +
 "                         <table  " +
 "                           align='center'  " +
 "                           border='0'  " +
 "                           cellpadding='0'  " +
 "                           cellspacing='0'  " +
 "                           role='presentation'  " +
 "                           style='width: 100%'  " +
 "                         >  " +
 "                           <tbody>  " +
 "                             <tr>  " +
 "                               <td  " +
 "                                 style='  " +
 "                                   direction: ltr;  " +
 "                                   font-size: 0px;  " +
 "                                   padding: 0;  " +
 "                                   padding-left: 0;  " +
 "                                   padding-right: 0;  " +
 "                                   text-align: center;  " +
 "                                 '  " +
 "                               >  " +
 "                                 <div  " +
 "                                   class='x_mj-column-per-100 x_mj-outlook-group-fix'  " +
 "                                   style='  " +
 "                                     font-size: 0px;  " +
 "                                     text-align: left;  " +
 "                                     direction: ltr;  " +
 "                                     display: inline-block;  " +
 "                                     vertical-align: top;  " +
 "                                     width: 100%;  " +
 "                                   '  " +
 "                                 >  " +
 "                                   <table  " +
 "                                     border='0'  " +
 "                                     cellpadding='0'  " +
 "                                     cellspacing='0'  " +
 "                                     role='presentation'  " +
 "                                     width='100%'  " +
 "                                     style='vertical-align: top'  " +
 "                                   >  " +
 "                                     <tbody>  " +
 "                                       <tr>  " +
 "                                         <td  " +
 "                                           align='center'  " +
 "                                           style='  " +
 "                                             font-size: 0px;  " +
 "                                             padding: 0 0;  " +
 "                                             word-break: break-word;  " +
 "                                           '  " +
 "                                         >  " +
 "                                           <table  " +
 "                                             border='0'  " +
 "                                             cellpadding='0'  " +
 "                                             cellspacing='0'  " +
 "                                             role='presentation'  " +
 "                                             style='  " +
 "                                               border-collapse: collapse;  " +
 "                                               border-spacing: 0px;  " +
 "                                             '  " +
 "                                           >  " +
 "                                             <tbody>  " +
 "                                               <tr>  " +
 "                                                 <td style='width: 600px; background-color: rgb(18 178 0); padding: 45px; border: 0px'>  " +
 "                                                 <div style='  " +
 "                                                   font-family: sans-serif;  " +
 "                                                   font-size: 28px;  " +
 "                                                   line-height: 100%;  " +
 "                                                   text-align: center;  " +
 "                                                   color: #fff;'>  " +
 "                                                 <strong>CONVITE ESPECIAL</strong>  " +
 "                                               </div>  " +
 "                                                 </td>  " +
 "                                               </tr>  " +
 "                                             </tbody>  " +
 "                                           </table>  " +
 "                                         </td>  " +
 "                                       </tr>  " +
 "                                     </tbody>  " +
 "                                   </table>  " +
 "                                 </div>  " +
 "                               </td>  " +
 "                             </tr>  " +
 "                           </tbody>  " +
 "                         </table>  " +
 "                       </div>  " +
 "                       <div style='margin: 0px auto; max-width: 600px'>  " +
 "                         <table  " +
 "                           align='center'  " +
 "                           border='0'  " +
 "                           cellpadding='0'  " +
 "                           cellspacing='0'  " +
 "                           role='presentation'  " +
 "                           style='width: 100%'  " +
 "                         >  " +
 "                           <tbody>  " +
 "                             <tr>  " +
 "                               <td  " +
 "                                 style='  " +
 "                                   direction: ltr;  " +
 "                                   font-size: 0px;  " +
 "                                   padding: 40px 40px 0 40px;  " +
 "                                   padding-left: 40px;  " +
 "                                   padding-right: 40px;  " +
 "                                   text-align: center;  " +
 "                                 '  " +
 "                               >  " +
 "                                 <div  " +
 "                                   class='x_mj-column-per-100 x_mj-outlook-group-fix'  " +
 "                                   style='  " +
 "                                     font-size: 0px;  " +
 "                                     text-align: left;  " +
 "                                     direction: ltr;  " +
 "                                     display: inline-block;  " +
 "                                     vertical-align: top;  " +
 "                                     width: 100%;  " +
 "                                   '  " +
 "                                 >  " +
 "                                   <table  " +
 "                                     border='0'  " +
 "                                     cellpadding='0'  " +
 "                                     cellspacing='0'  " +
 "                                     role='presentation'  " +
 "                                     width='100%'  " +
 "                                     style='vertical-align: top'  " +
 "                                   >  " +
 "                                     <tbody>  " +
 "                                       <tr>  " +
 "                                         <td  " +
 "                                           align='center'  " +
 "                                           style='  " +
 "                                             font-size: 0px;  " +
 "                                             padding: 0px;  " +
 "                                             word-break: break-word;  " +
 "                                           '  " +
 "                                         >  " +
 "                                           <div  " +
 "                                             style='  " +
 "                                               font-family: sans-serif;  " +
 "                                               font-size: 28px;  " +
 "                                               line-height: 250%;  " +
 "                                               text-align: center;  " +
 "                                               color: #fd0305e3;  " +
 "                                             '  " +
 "                                           >  " +
 "                                             <strong>Olá, Marcelo Bertinatto!</strong>  " +
 "                                           </div>  " +
 "                                         </td>  " +
 "                                       </tr>  " +
 "                                       <tr>  " +
 "                                         <td  " +
 "                                           align='center'  " +
 "                                           style='  " +
 "                                             font-size: 0px;  " +
 "                                             padding: 0px;  " +
 "                                             word-break: break-word;  " +
 "                                           '  " +
 "                                         >  " +
 "                                           <div  " +
 "                                             style='  " +
 "                                               font-family: sans-serif;  " +
 "                                               font-size: 16px;  " +
 "                                               line-height: 150%;  " +
 "                                               text-align: center;  " +
 "                                               color: #b5b3b3;  " +
 "                                             '  " +
 "                                           >  " +
 "                                             Tudo bem com você? Espero que sim.  " +
 "                                             <br><br>  " +
 "                                             Estava fazendo uma seleção de potenciais clientes para oferecer uma nova oportunidade de sala de sinais,   " +
 "                                             e seu nome logo me chamou atenção.  " +
 "                                             <br><br>  " +
 "                                             Por quê?  " +
 "                                             <br><br>  " +
 "                                             Porque agora somos representantes de um trader europeu aqui no Brasil. Ele é muito conhecido na europa e seu nome é Steve Angel.  " +
 "                                             <br><br>  " +
 "                                             Seus sinais tem uma assertividade de <strong style='color: rgb(241, 196, 15);text-shadow: rgb(241 196 15) 0px 0px 5px;'>90%+ todos os dias</strong>,   " +
 "                                             além de um <strong style='color: rgb(241, 196, 15);text-shadow: rgb(241 196 15) 0px 0px 5px;'>ROBÔ que envia sinais 24 horas/dia com a mesma assertividade.</strong>  " +
 "                                             <br><br>  " +
 "                                             Criamos uma sala específica para os futuros clientes testarem o nosso produto.  " +
 "                                             <br><br>  " +
 "                                             Gostaria de fazer umas operações com os nossos sinais? Te garanto que você não irá se arrepender!!  " +
 "                                             <br><br>  " +
 "                                             Clique no botão abaixo e venha conhecer!  " +
 "                                             <br><br>  " +
 "                                             👇👇👇👇👇👇👇👇👇👇  " +
 "                                           </div>  " +
 "                                         </td>  " +
 "                                       </tr>  " +
 "                                     </tbody>  " +
 "                                   </table>  " +
 "                                 </div>  " +
 "                               </td>  " +
 "                             </tr>  " +
 "                           </tbody>  " +
 "                         </table>  " +
 "                       </div>  " +
 "                       <div style='margin: 0px auto; max-width: 600px'>  " +
 "                         <table  " +
 "                           align='center'  " +
 "                           border='0'  " +
 "                           cellpadding='0'  " +
 "                           cellspacing='0'  " +
 "                           role='presentation'  " +
 "                           style='width: 100%'  " +
 "                         >  " +
 "                           <tbody>  " +
 "                             <tr>  " +
 "                               <td  " +
 "                                 style='  " +
 "                                   direction: ltr;  " +
 "                                   font-size: 0px;  " +
 "                                   padding: 20px 0 0px 0;  " +
 "                                   padding-left: 40px;  " +
 "                                   padding-right: 40px;  " +
 "                                   text-align: center;  " +
 "                                 '  " +
 "                               >  " +
 "                                 <div  " +
 "                                   class='x_mj-column-per-33-333333333333336 x_mj-outlook-group-fix'  " +
 "                                   style='  " +
 "                                     font-size: 0px;  " +
 "                                     text-align: left;  " +
 "                                     direction: ltr;  " +
 "                                     display: inline-block;  " +
 "                                     vertical-align: top;  " +
 "                                     width: 100%;  " +
 "                                   '  " +
 "                                 >  " +
 "                                   <table  " +
 "                                     border='0'  " +
 "                                     cellpadding='0'  " +
 "                                     cellspacing='0'  " +
 "                                     role='presentation'  " +
 "                                     width='100%'  " +
 "                                     style='vertical-align: top'  " +
 "                                   ></table>  " +
 "                                 </div>  " +
 "                                 <div  " +
 "                                   class='x_mj-column-per-33-333333333333336 x_mj-outlook-group-fix x_dropShadow-1'  " +
 "                                   style='  " +
 "                                     font-size: 0px;  " +
 "                                     text-align: left;  " +
 "                                     direction: ltr;  " +
 "                                     display: inline-block;  " +
 "                                     vertical-align: top;  " +
 "                                     width: 100%;  " +
 "                                   '  " +
 "                                 >  " +
 "                                   <table  " +
 "                                     border='0'  " +
 "                                     cellpadding='0'  " +
 "                                     cellspacing='0'  " +
 "                                     role='presentation'  " +
 "                                     width='100%'  " +
 "                                     style='vertical-align: top'  " +
 "                                   >  " +
 "                                     <tbody>                                      " +
 "                                       <tr>  " +
 "                                         <td align='center'>  " +
 "                                           <table  " +
 "                                             width='85%'  " +
 "                                             border='0'  " +
 "                                             align='center'  " +
 "                                             cellpadding='0'  " +
 "                                             cellspacing='0'  " +
 "                                           >  " +
 "                                             <tbody>  " +
 "                                               <tr>  " +
 "                                                 <td align='center'>  " +
 "                                                   <table  " +
 "                                                     class='x_textbutton'  " +
 "                                                     border='0'  " +
 "                                                     align='center'  " +
 "                                                     cellpadding='0'  " +
 "                                                     cellspacing='0'  " +
 "                                                   >  " +
 "                                                     <tbody>  " +
 "                                                       <tr>  " +
 "                                                         <td  " +
 "                                                           height='60'  " +
 "                                                           align='center'  " +
 "                                                           style='  " +
 "                                                             font-family: Montserrat,Arial, sans-serif;  " +
 "                                                             font-size: 14px;  " +
 "                                                             font-weight: 600;  " +
 "                                                             color: #ffffff;  " +
 "                                                             background: rgb(18 178 0);  " +
 "                                                             border-radius: 30px;  " +
 "                                                             border: 2px solid  " +
 "                                                             rgb(18 178 0);  " +
 "                                                             padding: 9px 35px;  " +
 "                                                             text-transform: uppercase;  " +
 "                                                           '  " +
 "                                                         >  " +
 "                                                           <a  " +
 "                                                             href='https://t.me/joinchat/Uzr_okibmCH9LTj1'  " +
 "                                                             target='_blank'  " +
 "                                                             rel='noopener noreferrer'  " +
 "                                                             data-auth='NotApplicable'  " +
 "                                                             style='color: #ffffff'  " +
 "                                                             >Entrar no Grupo do  " +
 "                                                             Telegram</a  " +
 "                                                           >  " +
 "                                                         </td>  " +
 "                                                       </tr>  " +
 "                                                     </tbody>  " +
 "                                                   </table>  " +
 "                                                 </td>  " +
 "                                               </tr>  " +
 "                                             </tbody>  " +
 "                                           </table>  " +
 "                                         </td>  " +
 "                                       </tr>  " +
 "                                     </tbody>  " +
 "                                   </table>  " +
 "                                 </div>  " +
 "                                 <div  " +
 "                                   class='x_mj-column-per-33-333333333333336 x_mj-outlook-group-fix'  " +
 "                                   style='  " +
 "                                     font-size: 0px;  " +
 "                                     text-align: left;  " +
 "                                     direction: ltr;  " +
 "                                     display: inline-block;  " +
 "                                     vertical-align: top;  " +
 "                                     width: 100%;  " +
 "                                   '  " +
 "                                 >  " +
 "                                   <table  " +
 "                                     border='0'  " +
 "                                     cellpadding='0'  " +
 "                                     cellspacing='0'  " +
 "                                     role='presentation'  " +
 "                                     width='100%'  " +
 "                                     style='vertical-align: top'  " +
 "                                   ></table>  " +
 "                                 </div>  " +
 "                               </td>  " +
 "                             </tr>  " +
 "                           </tbody>  " +
 "                         </table>  " +
 "                       </div>  " +
 "                       <div style='margin: 0px auto; max-width: 600px'>  " +
 "                         <table  " +
 "                           align='center'  " +
 "                           border='0'  " +
 "                           cellpadding='0'  " +
 "                           cellspacing='0'  " +
 "                           role='presentation'  " +
 "                           style='width: 100%'  " +
 "                         >  " +
 "                           <tbody>  " +
 "                             <tr>  " +
 "                               <td  " +
 "                                 style='  " +
 "                                   direction: ltr;  " +
 "                                   font-size: 0px;  " +
 "                                   padding: 20px 0;  " +
 "                                   padding-left: 40px;  " +
 "                                   padding-right: 40px;  " +
 "                                   text-align: center;  " +
 "                                 '  " +
 "                               >  " +
 "                                 <div  " +
 "                                   class='x_mj-column-per-100 x_mj-outlook-group-fix'  " +
 "                                   style='  " +
 "                                     font-size: 0px;  " +
 "                                     text-align: left;  " +
 "                                     direction: ltr;  " +
 "                                     display: inline-block;  " +
 "                                     vertical-align: top;  " +
 "                                     width: 100%;  " +
 "                                   '  " +
 "                                 >  " +
 "                                   <table  " +
 "                                     border='0'  " +
 "                                     cellpadding='0'  " +
 "                                     cellspacing='0'  " +
 "                                     role='presentation'  " +
 "                                     width='100%'  " +
 "                                     style='vertical-align: top'  " +
 "                                   ></table>  " +
 "                                 </div>  " +
 "                               </td>  " +
 "                             </tr>  " +
 "                           </tbody>  " +
 "                         </table>  " +
 "                       </div>  " +
 "                       <div style='margin: 0px auto; max-width: 600px'>  " +
 "                         <table  " +
 "                           align='center'  " +
 "                           border='0'  " +
 "                           cellpadding='0'  " +
 "                           cellspacing='0'  " +
 "                           role='presentation'  " +
 "                           style='width: 100%'  " +
 "                         >  " +
 "                           <tbody>  " +
 "                             <tr>  " +
 "                               <td  " +
 "                                 style='  " +
 "                                   direction: ltr;  " +
 "                                   font-size: 0px;  " +
 "                                   padding: 20px 0;  " +
 "                                   padding-bottom: 0;  " +
 "                                   padding-left: 40px;  " +
 "                                   padding-right: 40px;  " +
 "                                   text-align: center;  " +
 "                                 '  " +
 "                               >  " +
 "                                 <div  " +
 "                                   class='x_mj-column-per-100 x_mj-outlook-group-fix'  " +
 "                                   style='  " +
 "                                     font-size: 0px;  " +
 "                                     text-align: left;  " +
 "                                     direction: ltr;  " +
 "                                     display: inline-block;  " +
 "                                     vertical-align: top;  " +
 "                                     width: 100%;  " +
 "                                   '  " +
 "                                 >  " +
 "                                   <table  " +
 "                                     border='0'  " +
 "                                     cellpadding='0'  " +
 "                                     cellspacing='0'  " +
 "                                     role='presentation'  " +
 "                                     width='100%'  " +
 "                                     style='vertical-align: top'  " +
 "                                   >  " +
 "                                     <tbody>  " +
 "                                       <tr>  " +
 "                                         <td  " +
 "                                           align='center'  " +
 "                                           style='  " +
 "                                             font-size: 0px;  " +
 "                                             padding: 0px;  " +
 "                                             word-break: break-word;  " +
 "                                           '  " +
 "                                         >  " +
 "                                           <div  " +
 "                                             style='  " +
 "                                               font-family: sans-serif;  " +
 "                                               font-size: 16px;  " +
 "                                               line-height: 150%;  " +
 "                                               text-align: center;  " +
 "                                               color: #b5b3b3;  " +
 "                                             '  " +
 "                                           >  " +
 "                                             Abraços,  " +
 "                                             <br />João Trader  " +
 "                                             <br />Equipe Angel Signals Brasil  " +
 "                                           </div>  " +
 "                                         </td>  " +
 "                                       </tr>  " +
 "                                     </tbody>  " +
 "                                   </table>  " +
 "                                 </div>  " +
 "                               </td>  " +
 "                             </tr>  " +
 "                           </tbody>  " +
 "                         </table>  " +
 "                       </div>  " +
 "                     </td>  " +
 "                   </tr>  " +
 "                 </tbody>  " +
 "               </table>  " +
 "             </div>  " +
 "             <div style='margin: 0px auto; max-width: 600px'>  " +
 "               <table  " +
 "                 align='center'  " +
 "                 border='0'  " +
 "                 cellpadding='0'  " +
 "                 cellspacing='0'  " +
 "                 role='presentation'  " +
 "                 style='width: 100%'  " +
 "               >  " +
 "                 <tbody>  " +
 "                   <tr>  " +
 "                     <td  " +
 "                       style='  " +
 "                         direction: ltr;  " +
 "                         font-size: 0px;  " +
 "                         padding: 20px 0;  " +
 "                         padding-left: 40px;  " +
 "                         padding-right: 40px;  " +
 "                         padding-top: 30px;  " +
 "                         text-align: center;  " +
 "                       '  " +
 "                     >  " +
 "                       <div  " +
 "                         class='x_mj-column-per-100 x_mj-outlook-group-fix'  " +
 "                         style='  " +
 "                           font-size: 0px;  " +
 "                           text-align: left;  " +
 "                           direction: ltr;  " +
 "                           display: inline-block;  " +
 "                           vertical-align: top;  " +
 "                           width: 100%;  " +
 "                         '  " +
 "                       >  " +
 "                         <table  " +
 "                           border='0'  " +
 "                           cellpadding='0'  " +
 "                           cellspacing='0'  " +
 "                           role='presentation'  " +
 "                           width='100%'  " +
 "                           style='vertical-align: top'  " +
 "                         >  " +
 "                           <tbody>  " +
 "                             <tr>  " +
 "                               <td  " +
 "                                 align='center'  " +
 "                                 style='  " +
 "                                   font-size: 0px;  " +
 "                                   padding: 10px 25px;  " +
 "                                   word-break: break-word;  " +
 "                                 '  " +
 "                               >  " +
 "                                 <table  " +
 "                                   align='center'  " +
 "                                   border='0'  " +
 "                                   cellpadding='0'  " +
 "                                   cellspacing='0'  " +
 "                                   role='presentation'  " +
 "                                   style='float: none; display: inline-table'  " +
 "                                 >  " +
 "                                   <tbody>  " +
 "                                     <tr>  " +
 "                                       <td style='padding: 4px'>  " +
 "                                         <table  " +
 "                                           border='0'  " +
 "                                           cellpadding='0'  " +
 "                                           cellspacing='0'  " +
 "                                           role='presentation'  " +
 "                                           style='border-radius: 3px; width: 40px'  " +
 "                                         >  " +
 "                                           <tbody>  " +
 "                                             <tr>  " +
 "                                               <td  " +
 "                                                 style='  " +
 "                                                   font-size: 0;  " +
 "                                                   height: 40px;  " +
 "                                                   vertical-align: middle;  " +
 "                                                   width: 40px;  " +
 "                                                 '  " +
 "                                               >  " +
 "                                                 <a  " +
 "                                                   href='https://www.facebook.com/angelsignalsbr'  " +
 "                                                   target='_blank'  " +
 "                                                   rel='noopener noreferrer'  " +
 "                                                   data-auth='NotApplicable'  " +
 "                                                 >  " +
 "                                                   <img  " +
 "                                                     data-imagetype='External'  " +
 "                                                     src='https://nu-emails.s3.amazonaws.com/ico-facebook-grey.png'  " +
 "                                                     height='40'  " +
 "                                                     width='40'  " +
 "                                                     style='  " +
 "                                                       border-radius: 3px;  " +
 "                                                       display: block;  " +
 "                                                     '  " +
 "                                                   />  " +
 "                                                 </a>  " +
 "                                               </td>  " +
 "                                             </tr>  " +
 "                                           </tbody>  " +
 "                                         </table>  " +
 "                                       </td>  " +
 "                                     </tr>  " +
 "                                   </tbody>  " +
 "                                 </table>  " +
 "                                 <table  " +
 "                                   align='center'  " +
 "                                   border='0'  " +
 "                                   cellpadding='0'  " +
 "                                   cellspacing='0'  " +
 "                                   role='presentation'  " +
 "                                   style='float: none; display: inline-table'  " +
 "                                 >  " +
 "                                   <tbody>  " +
 "                                     <tr>  " +
 "                                       <td style='padding: 4px'>  " +
 "                                         <table  " +
 "                                           border='0'  " +
 "                                           cellpadding='0'  " +
 "                                           cellspacing='0'  " +
 "                                           role='presentation'  " +
 "                                           style='border-radius: 3px; width: 40px'  " +
 "                                         >  " +
 "                                           <tbody>  " +
 "                                             <tr>  " +
 "                                               <td  " +
 "                                                 style='  " +
 "                                                   font-size: 0;  " +
 "                                                   height: 40px;  " +
 "                                                   vertical-align: middle;  " +
 "                                                   width: 40px;  " +
 "                                                 '  " +
 "                                               >  " +
 "                                                 <a  " +
 "                                                   href='https://instagram.com/angelsignalsbr?igshid=oox7hle8tbge'  " +
 "                                                   target='_blank'  " +
 "                                                   rel='noopener noreferrer'  " +
 "                                                   data-auth='NotApplicable'  " +
 "                                                 >  " +
 "                                                   <img  " +
 "                                                     data-imagetype='External'  " +
 "                                                     src='https://nu-emails.s3.amazonaws.com/ico-instagram-grey.png'  " +
 "                                                     height='40'  " +
 "                                                     width='40'  " +
 "                                                     style='  " +
 "                                                       border-radius: 3px;  " +
 "                                                       display: block;  " +
 "                                                     '  " +
 "                                                   />  " +
 "                                                 </a>  " +
 "                                               </td>  "  + 
 "                                             </tr>  " +
 "                                           </tbody>  " +
 "                                         </table>  " +
 "                                       </td>  " +
 "                                     </tr>  " +
 "                                   </tbody>  " +
 "                                 </table>  " +
 "                               </td>  " +
 "                             </tr>  " +
 "                           </tbody>  " +
 "                         </table>  " +
 "                       </div>  " +
 "                     </td>  " +
 "                   </tr>  " +
 "                 </tbody>  " +
 "               </table>  " +
 "             </div>  " +
 "           </div>  " +
 "         </div>  " +
 "       </div>  " +
 "     </body>  " +
 "   </html>  ",
                IsBodyHtml =true
            };

            EmailSendResult Result = GmailSender.SendEmail(Message);
            if(Result.IsMessageDelivered)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Email Is Delivered!");
                Console.ReadLine();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string error = string.Format("Email is not delivered due to following error \r\n{0}", Result.Error.Message);
                Console.WriteLine(error);
            }
        }
    }
}
