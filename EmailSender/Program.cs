using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailSender
{
    class Program
    {
        static void Main(string[] args)
        {

            var contactList = GetContactList();

            GmailClientInfo client = new GmailClientInfo() {
                 GmailUserEmail= "jvssbrito@gmail.com",
                 GmailUserPassword= "mwkevjfatwzqrdpg",                  
            };

            IEmailSender GmailSender = new GmailEmailSender(client);

            foreach (var item in contactList)
            {
                if (item.Key.Equals("Marcelo Bertinatto D' Onofrio"))
                {
                    EmailMessage Message = new EmailMessage()
                    {
                        TO = new List<string>() { item.Key.ToString() },
                        CC = null,
                        Subject = "Está equipe de traders trouxeram a melhor sala de sinais da Europa para o Brasil. Venha conhecer agora!",
                        Body = GetBody(item.Value.ToString()),
                        IsBodyHtml = true
                    };

                    EmailSendResult Result = GmailSender.SendEmail(Message);
                    if (Result.IsMessageDelivered)
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


            //EmailMessage Message = new EmailMessage()
            //{
            //    TO = new List<string>() { "marcelobertinatto@hotmail.com" },
            //    CC=null,
            //    Subject="Está equipe de traders trouxeram a melhor sala de sinais da Europa para o Brasil. Venha conhecer agora!",
            //    Body = GetBody(),
            //    IsBodyHtml =true
            //};

            //EmailSendResult Result = GmailSender.SendEmail(Message);
            //if(Result.IsMessageDelivered)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Email Is Delivered!");
            //    Console.ReadLine();

            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    string error = string.Format("Email is not delivered due to following error \r\n{0}", Result.Error.Message);
            //    Console.WriteLine(error);
            //}
        }

        public static string GetBody(string name)
        {
            return "   <html>  " +
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
 "                                             <strong>Olá, "+name+"!</strong>  " +
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
 "                                               </td>  " +
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
 "   </html>  ";
        }

        public static Dictionary<string,string> GetContactList()
        {
            Dictionary<string, string> contactList = new Dictionary<string, string>()
            {
                { "Elton de Oliveira Júnior", "elton-tb@hotmail.com" },
                    { "ROGER RABELLO FERNANDES", "rogerrabello8@gmail.com" },
                    { "leonardo Camargo Zanetti", "leoczanetti@gmail.com" },
                    { "Nilva Martins do Nascimento", "nilvafloreira@gmail.com" },
                    { "Fernando Moreira Braga", "frtnandogalobraga@gmail.com" },
                    { "Luiz Fernando de Oliveira Gonçalves", "fer1goncalves@gmail.com" },
                    { "ELITERIO CANISIO HERBERT", "altaircanisiohertz@hotmail.com" },
                    { "Janderson do Nascimento pereira", "jandersonnp@hotmail.com" },
                    { "Elves Gonçalves Lima", "elveslima17@gmail.com" },
                    { "Ilceny Maria Aparecida Almeida", "ilcenym@gmail.com" },
                    { "Michel Luiz dos Santos Pereira", "tradermcl@gmail.com" },
                    { "Lucas Mateus Borges dos Santos", "lmateusborgesdossantos@gmail.com" },
                    { "Thiago de Oliveira Aguilera Higa", "higa_thiago@hotmail.com" },
                    { "Paulo do Carmo Rosa De Almeida", "paulinhofinancas@gmail.com" },
                    { "Felipe Boni Jacoboski", "felipejacoboski12@hotmail.com" },
                    { "Lucas de Souza Marquesa", "lucassouzam2010@gmail.com" },
                    { "Leonardo Barbosa Menezes", "leonardo.barbosa.m37@gmail.com" },
                    { "Matheus Carvalho Ronzani", "mronzani1991@gmail.com" },
                    { "Andreson de Almeida", "andresonalmeida.aaa@gmail.com" },
                    { "Carlos Hermes", "carloshermes32@gmail.com" },
                    { "Marcelo Fregoneze", "marcelo_fregoneze@hotmail.com" },
                    { "Valdecir Dreher", "dreherval@gmail.com" },
                    { "Diogo Maia Azevedo", "diegoazevedo823@gmail.com" },
                    { "ocimar aparecido lisboa", "ocimaraplisboa@hotmail.com" },
                    { "EUGENIO MARTINELLI", "foimartinelli@gmail.com" },
                    { "Vitor Abel de Alcântara dos Santos", "vitor.abel77@gmail.com" },
                    { "Roberto Rodrigues Costa", "atitudemodamaior@hotmail.com" },
                    { "Rafael Santos Pereira", "rafa_pereira7@hotmail.com" },
                    { "David Anderson da Silva", "da3922706@gmail.com" },
                    { "Melquisedeque Welson Dos Anjos", "melquisedequewelson@gmail.com" },
                    { "Gilcimar santana", "gilcimarsantana@hotmail.com" },
                    { "LUIZ HENRIQUE DE SOUSA MOREIRA", "luizherinque.moreira10@gmail.com" },
                    { "Jefferson de Sousa vaes", "jeffersonvaissousa@gmail.com" },
                    { "Alberson Ribeiro Bruno", "arbruno@bol.com.br" },
                    { "italo uchoa oliveira", "98iuchoa@gmail.com" },
                    { "Antonio Augusto da Silveira Muniz", "gustosilveira@hotmail.com" },
                    { "Cayan das Neves de Mello", "cayanneves@gmail.com" },
                    { "André Luiz fadanni", "andrefadanni@icloud.com" },
                    { "CRISTINA ALBUQUERQUE DOUBERIN", "cristinaadouberin@hotmail.com" },
                    { "Bruno de Souza Barreto", "brunobarretto01@gmail.com" },
                    { "Josias Mendonça Ramos Júnior", "mendoonca.jr@hotmail.com" },
                    { "Joice Christ", "joice_christ00@hotmail.com" },
                    { "Wellington candido da Silva", "wellingtonsilvinha001@gmail.com" },
                    { "Rodrigo de Queiroz da Costa", "rodrigoqdacosta@gmail.com" },
                    { "Bruno wilker Teixeira Leal", "brunowilker009@gmail.com" },
                    { "Aron matheus alencar da silva", "matheusalencar3840@gmail.com" },
                    { "SAMUEL AMANCIO MOREIRA", "samuelgvicm@hotmail.com" },
                    { "Thiago Rafael da Silva", "silva_thiago@hotmail.com" },
                    { "GUILHERME LIDEME DE CASTILHO", "guiihxbox@gmail.com" },
                    { "Yan Souza de Oliveira", "oliveira.357@outlook.com" },
                    { "Leandro Henrique Dorighetti Cavalcanti", "leandro.dorighetti@gmail.com" },
                    { "Vinícius pinto de Rezende", "vprezende@gmail.com" },
                    { "Jorge Teodoro de Oliveira Júnior", "juniorxt660@outlook.com" },
                    { "Sidnei Francisco do nascimento Júnior", "sdineij@gmail.com" },
                    { "Rafael Henrique Ochiliski Gern", "rafagern@gmail.com" },
                    { "Paulo Santiego Vieira", "paulosantiego@gmail.com" },
                    { "Felipe Laurentino Carlos", "fe.park@hotmail.com" },
                    { "iara dos santos freitas", "santosfreitasiara@gmail.com" },
                    { "João Paulo Lopes de Souza", "jp.joaopaulo1612@gmail.com" },
                    { "Roberto Guimarães de Oliveira Nascimento", "robertoguimaraes48@hotmail.com" },
                    { "Abraão Fortes De Carvalho", "carvalhoabraao744@gmail.com" },
                    { "Douglas Mendonça de Lima", "douglasmendrp@hotmail.com" },
                    { "José Gustavo Lima", "gustahjr@gmail.com" },
                    { "Natan Gabriel Beilfuss", "natanbeilfuss@outlook.com" },
                    { "joao pedro fontes ferraretto", "jp@ferrarettohotel.com.br" },
                    { "Carla Patrícia Nucci Bueno", "raphael_nucci@yahoo.com.br" },
                    { "Lucas Ramon Rohr", "lucas_rohr96@hotmail.com" },
                    { "Diego Pires Muller", "diego3446muller@gmail.com" },
                    { "Marianne Joya Viera", "joyamelo2000@gmail.com" },
                    { "Kauan costa santos", "skauan459@gmail.com" },
                    { "victor cristiano pereira barreto", "hugo.torquato11@hotmail.com" },
                    { "Gregory Barros Oliveira", "gregorytrader21@gmail.com" },
                    { "MANOEL DUMKE RAUGUST", "manoeldumke@gmail.com" },
                    { "KARTHEN J R CHAVES", "karthen.junior@gmail.com" },
                    { "Thales Santana", "thaleseq@gmail.com" },
                    { "Joao Francisco Prates Junior", "johnny.fernandes45@gmail.com" },
                    { "Valdir Domingos de Araujo", "viniaraujo1114@gmail.com" },
                    { "Robson Brandão Nogueira", "robson.brandao@outlook.com" },
                    { "Weslley Henrique Alves Ferreira", "weslleyhenriquealves@hotmail.com" },
                    { "Matheus Gabriel Menghi Soder", "m.soder2508@gmail.com" },
                    { "Rafael Azevedo Santana", "rafael_santana89@hotmail.com" },
                    { "Higor Henrique Moreira Cruz", "higao12henrique@gmail.com" },
                    { "Bruno Deodilio de Macedo Santos", "bruno-santos11@hotmail.com" },
                    { "Marcos Daniel Rusch", "ruschinho@hotmail.com" },
                    { "marcos daniel nardini", "marcos_mdn@outlook.com" },
                    { "Paulo Henrique Martins Ferreira", "fiotph14@gmail.com" },
                    { "Agnaldo Rael Rodrigues Junior", "agnaldorrj00@gmail.com" },
                    { "Matheus name amaral", "matheus2504@live.com" },
                    { "Jefferson Nunes leite", "jeffersonnl1993@gmail.com" },
                    { "Rudson Aylan Soares ribeiro", "rudsonaylan95@gmail.com" },
                    { "Hércules de araujo borges", "dinheirodolar93@gmail.com" },
                    { "Thyago de Oliveira", "ubimed1@hotmail.com" },
                    { "Giovanni Graciano Vasconcelos", "giovanni.graciano.gg@gmail.com" },
                    { "Fernanda Hofke da Costa", "hofke78@hotmail.com" },
                    { "Matheus ferreira Nunes Silva", "matheusferreiragu2@gmail.com" },
                    { "Tharlles Andrade de Melo", "tharlles_mello@hotmail.com" },
                    { "Fábio de Sousa Nascimento", "sousafabio758@gmail.com" },
                    { "Lucas Tadeu Silva Melo", "andreirairdes@hotmail.com" },
                    { "Frederico jose lima braga leal", "fredericojoseleal@gmail.com" },
                    { "Wallace oliveira Machado", "machadowallace15@gmail.com" },
                    { "Edson Pablo", "edsonpablo23@gmail.com" },
                    { "marcos Rogerio Nogueira Das Chagas Oliveiras", "canalpaoqueijo2@gmail.com" },
                    { "Haroldo Gondim Torres Neto", "haroldogondim@hotmail.com" },
                    { "André Matos de oliveira", "andre22matos@gmail.com" },
                    { "Joao luis Silva Calabres", "joao4luis5@gmail.com" },
                    { "André Luiz Sete", "sete.andre@hotmail.com" },
                    { "matheus de oliveira souza", "matheusjs1997@gmail.com" },
                    { "Luiz Antônio da Silva Ferrari Braga", "luiz.ferrari.braga@hotmail.com" },
                    { "Jiniane Souza Santos", "santiago.o113@outlook.com" },
                    { "Lucas araujo da cunha", "lukinhasarau@gmail.com" },
                    { "Hamilton de Souza Júnior", "hamilton.trader1809@gmail.com" },
                    { "Jaime Anastácio Verçosa Neto", "jaimevercosa@gmail.com" },
                    { "Adriano Elias Monteiro Silva e Silva", "adrianoeliasms@gmail.com" },
                    { "Maria de Fátima dos santos", "euescolhivaroar2000@gmail.com" },
                    { "Lucas barcellos cesar", "lucas.bc@hotmail.com" },
                    { "Luiz Gustavo Vieira de Freitas", "lgvf007@gmail.com" },
                    { "Valto Gomes Pereira", "valtinho2007@outlook.com" },
                    { "Sadi Antonio de Araujo Junior", "sadi.junior.rs@hotmail.com" },
                    { "Anderson dos santos", "anderson8213@hotmail.com" },
                    { "Felipe Nogueira", "felipe.tch@hotmail.com" },
                    { "Rodrigo Dos Santos Oliveira", "rodrigoedry@hotmail.com" },
                    { "dennis moura monteiro", "dennismmoura97@gmail.com" },
                    { "Artur Graçano Ribeiro", "gracano2@gmail.com" },
                    { "Wagner Dionisio Correia", "wagner-santa@hotmail.com" },
                    { "Ronaldo Valença dos Santos", "ronyvalsan@gmail.com" },
                    { "Lucas Vinícius Ferreira da Silva", "lucasvf536@gmail.com" },
                    { "Bruno Marques Sales", "bruno.m.sales@hotmail.com" },
                    { "Yan Marcos Pavi", "pocketpavi@gmail.com" },
                    { "David Anderson da Silva", "dd360110@gmail.com" },
                    { "williane lima da silva", "vantusoficial2020@gmail.com" },
                    { "angela maria pastor santana", "angelamaria363836@gmail.com" },
                    { "Luccas do Carmo Silva", "luccas_cdc@hotmail.com" },
                    { "PABLO VAGNER DIAS DOS REIS", "pablovddr@gmail.com" },
                    { "Rosemberg Passos da Costa", "bergfj@hotmail.com" },
                    { "Alex Laquiman Faria", "alex.laquiman51@gmail.com" },
                    { "Pedro Moraes Iunes", "pedrinhoiunes@gmail.com" },
                    { "Anderson de Oliveira Cabral", "anderson.ocabral@gmail.com" },
                    { "Orlei Moreira Santos", "orleimonetizze001@gmail.com" },
                    { "Andrew de Mello martinez", "andrewmello.engcivil@gmail.com" },
                    { "Carlos Juan Lima", "carlosjuanlima7@icloud.com" },
                    { "Vanderson Juninho Soares", "vanderson-botu@hotmail.com" },
                    { "Naidson Gama dos Santos", "nulo.net@gmail.com" },
                    { "Emanoel dos Santos Pereira", "emanueltrader1.et544@gmail.com" },
                    { "Pedro Henrique Gonçalves Andrade", "pedrodocruzeiro123@hotmail.com" },
                    { "Gabriel dias de oliveira", "gabrielsanfamily@gmail.com" },
                    { "Sergio de Mello", "sergio@ishisupuma.com.br" },
                    { "Alex Luan Sepulveda Suque", "alexsuque18k@gmail.com" },
                    { "Adriano gramlich Fernandes", "adriano.adriard@gmail.com" },
                    { "Ronei baldoria Silverio", "ronei_jts90@hotmail.com" },
                    { "Nicolas Cristian Silveira Batista", "nicolascristian007@gmail.com" },
                    { "WENICIUS ANTONIO DA CONCEIÇÃO", "w.melhoramentos@gmail.com" },
                    { "Alessandra Maciel Ferreira", "luizcarlosribeiro198@gmail.com" },
                    { "Roselane Gomes de Andrade", "laynegomes@hotmail.com" },
                    { "Rodolfo ramos Lopes da Silva", "rodolforamos2017@gmail.com" },
                    { "Luan Carlos Oliveira de Aquino", "aquinoinvestimento@gmail.com" },
                    { "Marcos Wenderson Moreira da Costa", "marcoswenderson241@gmail.com" },
                    { "Jose geraldo maciel", "gera123trader@gmail.com" },
                    { "João Victor Da Rocha Pequeno", "joao.rochapeq@gmail.com" },
                    { "Ulisses Damacena Ribeiro Silva lobo", "ulissesdamacena@gmail.com" },
                    { "Pedro Gabriel Martins policarpo stumm", "pedrostummfilms@gmail.com" },
                    { "Leonardo Ribeiro Aquino", "leo_aquino@msn.com" },
                    { "Elisson Salgado Barros", "salgado.elisson@gmail.com" },
                    { "Jaime Almeida dos Santos", "jaime.almeida998@gmail.com" },
                    { "João Omar Correia neto", "joaoomarneto@gmail.com" },
                    { "Rafael Anderson da Silva", "rafaelsilvajf06@gmail.com" },
                    { "Rafael Alencar Teixeira", "rafaelalencart@gmail.com" },
                    { "Juan de Oliveira felix", "juandeoliveirafeliiix@gmail.com" },
                    { "Carolina Grassmann", "grass.c@hotmail.com" },
                    { "Bruno Borges", "brunofla27@gmail.com" },
                    { "Greiciely Mangini de Castro", "greiciely.mangini@gmail.com" },
                    { "Pedro Igor Rodrigues Lima", "pedroigorr13@gmail.com" },
                    { "Matheus Ferreira de Assis", "homempeixe202@gmail.com" },
                    { "Matheus da costa morais", "theuskateordie@hotmail.com" },
                    { "Cayan das Neves de Mello", "theuskateordie@hotmail.com" },
                    { "Tiago Vitor de Almeida", "tiago.almeida110833@gmail.com" },
                    { "Fernando Calmon Figueiredo", "facilclube@gmail.com" },
                    { "Rogério Vinicius de Jesus Duarte", "rvjdu1@gmail.com" },
                    { "Matheus menezes vinagreiro", "matheus.vinagreiro03@gmail.com" },
                    { "Matheus Bueno Lima", "matheusbuenolima@gmail.com" },
                    { "Jailson Marques Almondes Sousa", "jailsonmarques75@gmail.com" },
                    { "Mauro de oliveira Salgado", "mauro.elaine@hotmail.com" },
                    { "ighor Abraão gerlani Gonçalves de Carvalho", "ighor.ab22@icloud.com" },
                    { "gabriel oliveira dias", "gabrieljesusdias001@gmail.com" },
                    { "Bruno Hudson Gomes Lourenço", "brunohudson581@gmail.com" },
                    { "Natália de Faria Faleiros", "nataliafaria000@gmail.com" },
                    { "Cesar augusto ramirez bustos", "cesaramirez6996@gmail.com" },
                    { "Gabriel Janousek", "gabrieljanousek@gmail.com" },
                    { "Suziléa Andréa Leal do Prado", "suzilea.prado@hotmail.com" },
                    { "Christian da Silva Paim", "paimchristian07@gmail.com" },
                    { "Marllon eriky theodoro machado", "marlloneriky15@gmail.com" },
                    { "Jonathan Alves Conde", "jon.ffc@icloud.com" },
                    { "MARCIO ARAUJO FERREIRA E ALMEIDA", "araujomarcio60@gmail.com" },
                    { "João paulo aparecido lima", "jplimadiamante@gmail.com" },
                    { "Rodrigo Nunes Loureiro", "rn01904@gmail.com" },
                    { "Vinicius silveira de gois", "vinigois8@outlook.com" },
                    { "Diego da Silva", "diegogas10@gmail.com" },
                    { "PEDRO BARRETO NETO", "pedrobarretoneto@yahoo.com.br" },
                    { "Rodrigo Ferreira dos Santos", "rodrigoferreirasantos58@gmail.com" },
                    { "Otavio Luiz Assis dos Prazeres", "oluiz047@gmail.com" },
                    { "Antônio Carlos da Silva Araújo", "cabeca.r7@gmail.com" },
                    { "Jardel de Sousa forte Teixeira", "jardel_20@yahoo.com.br" },
                    { "Leandro Ribeiro Marcos", "leandro_ribeirvo_marcos@hotmail.com" },
                    { "Allyson Nascimento Guimarães", "allyson.otaku1@gmail.com" },
                    { "Shelton Rezende", "sheltonrezende10@gmail.com" },
                    { "Erica dos Santos Bezerra", "erikaadossantos@gmail.com" },
                    { "GILSON FREITAS DIAS", "gfdiascontabilidade@gmail.com" },
                    { "Alessandro Magalhães de Almeida", "magalhaesproducoes@outlook.com" },
                    { "Natanael Guimarães", "nata.silva10@gmail.com" },
                    { "André Kaizer Souza", "andrekaizer1997@gmail.com" },
                    { "Dionatas Boita Veiga", "dionboita@gmail.com" },
                    { "Rafael Oliveira Farias", "rafa.oliveirafarias@outlook.com" },
                    { "Antônio Humberto de Sousa Silva", "digitall.contas@gmail.com" },
                    { "Lucas Matheus Romão Leal", "lucasmrleal@gmail.com" },
                    { "Omar de Oliveira Osório Neto", "netoomar447@gmail.com" },
                    { "Everton dos santos nunes", "evertonnunes425@gmail.com" },
                    { "Marcelo Alves Marques", "malvesmarques@gmail.com" },
                    { "Flater Junio Germano", "flaterjunior@gmail.com" },
                    { "Felipe Alves galvao", "felipegalvao8901@gmail.com" },
                    { "FRANCIS WILLIAN DA SILVA CARDOSO", "contato.nmrkprodutos@gmail.com" },
                    { "Lucas Oliveira de Souza", "lucasdark01@gmail.com" },
                    { "Guilherme Fernandes coelho", "guilhermefcoelho@hotmail.com" },
                    { "Matheus Silva Campos", "campos.mat01@gmail.com" },
                    { "MARIZELE ALMEIDA DE SOUSA", "marizelealmeidadesousa@gmail.com" },
                    { "MICHELA DA SILVA COSTA", "michelascosta.adv@gmail.com" },
                    { "Agenor Pereira da Silva Neto", "elinor.mtm@gmail.com" },
                    { "Gabriel Fernando Pires Carvalho", "checkpointbrasil0@gmail.com" },
                    { "João Lucas Marques Alves", "jlmalves2017@gmail.com" },
                    { "Miguel Oliveira do Rego", "contato.miguel190@icloud.com" },
                    { "Francesco toschi incerti", "incerti56@gmail.com" },
                    { "Carlos Eduardo Pinho Neto Figueiredo", "ceneto93@hotmail.com" },
                    { "Eduardo Domingos Morais Araujo", "0705.araujo.1327@gmail.com" },
                    { "Leonardo Duarte Sa", "leosa4@hotmail.com" },
                    { "Marcilio Bruno Ventura", "marciliobruno5@gmail.com" },
                    { "Francisco de Assis Costa Filho", "segundinho2013@gmail.com" },
                    { "Luan Gonçalves campista", "luancampista36@gmail.com" },
                    { "Jhonatan De Aguiar Silva", "jhonatanaguiar013@hotmail.com" },
                    { "César Henrique da Conceição Figueiredo", "cesarhenriquec507@gmail.com" },
                    { "Lucas Santos", "lucas.santosfsa@gmail.com" },
                    { "Gabriel Domingos de Assis", "domingos.gabriel2010@hotmail.com" },
                    { "Flori Sobrinho", "engenharia.geox@gmail.com" },
                    { "João Tadeu do Carmo Junior", "jtjacui@yahoo.com.br" },
                    { "joao vitor alves da silva", "joaovitoralvesover@gmail.com" },
                    { "Francisco Carlos Marques Barbosa", "carlosmagnum1@yahoo.com.br" },
                    { "Valdoir Andretta", "valdoirproooz1nnandretta@gmail.com" },
                    { "Pedro Ivo Souza Ramos", "pedroivoinveste2019@gmail.com" },
                    { "Thiago Henrique Almeida Ribas", "thiago.hribas@gmail.com" },
                    { "Joao luis gomes da silva", "joao.confraria@gmail.com" },
                    { "Maurício Fernandes Machado", "mauricio.fmachado@outlook.com" },
                    { "Julio Magalhães", "julitomagalhaes@gmail.com" },
                    { "David Felipe Soares", "davidfelsoares@gmail.com" },
                    { "MARIA BERENICE ZANANDREA", "estevanportolan123@gmail.com" },
                    { "Amanda Pereira da Cunha", "renanramalho74@gmail.com" },
                    { "Diego Oliveira felix", "diegodavilucas2019@gmail.com" },
                    { "Gabriel Teixeira", "gp291338@gmail.com" },
                    { "Duane Fernanda Conceição Teixeira", "duanefc@outlook.com" },
                    { "Darley Wagner Magalhães Ribeiro Junior", "dwjunior26on@gmail.com" },
                    { "JONATHAS DE MELO CHAGAS", "jonathasdemelochagas@gmail.com" },
                    { "Vinícius Rodrigo de Almeida Silva", "vinicius_rodrigo10@hotmail.com" },
                    { "Juan Pereira Freire", "juan.freire.397@gmail.com" },
                    { "Ricardo Carvalho lima", "ranchoaloisiolima@yahoo.com.br" },
                    { "Gabriel Dias Nocce", "gabriel.diasnocce@gmail.com" },
                    { "Luana Pires muller", "luhmuller2001@gmail.com" },
                    { "Helder Henrique Soares de freitas", "helder10freitas@gmail.com" },
                    { "Felipe Gabriel Ferreira Winter", "fehnalle@gmail.com" },
                    { "WAGNER NERY", "juniorwagner485@gmail.com" },
                    { "Natanael Ferreira da Silva", "fnatanael678@gmail.com" },
                    { "Marcelo Bertinatto D' Onofrio", "marcelobertinatto@hotmail.com" }
            };

            return contactList;
        }
    }
}
