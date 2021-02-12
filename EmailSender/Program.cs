using System;
using System.Collections.Generic;

namespace EmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var contactList = GetContactList();

                GmailClientInfo client = new GmailClientInfo()
                {
                    GmailUserEmail = "jvssbrito@gmail.com",
                    GmailUserPassword = "mwkevjfatwzqrdpg",
                };

                IEmailSender GmailSender = new GmailEmailSender(client);

                foreach (var item in contactList)
                {
                    if (item.Value.Equals("marcelobertinatto@hotmail.com"))
                    {

                        EmailMessage Message = new EmailMessage()
                        {
                            TO = new List<string>() { item.Value.ToString() },
                            CC = null,
                            Subject = "Está equipe de traders trouxeram a melhor sala de sinais da Europa para o Brasil. Venha conhecer agora!",
                            Body = GetBody(item.Key.ToString()),
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
            }
            catch (Exception ex)
            {
                throw ex;
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
            Dictionary<string, string> contactList = new Dictionary<string, string>();
            contactList.Add("Elton de Oliveira Júnior", "elton-tb@hotmail.com");
            contactList.Add("ROGER RABELLO FERNANDES", "rogerrabello8@gmail.com");
            contactList.Add("leonardo Camargo Zanetti", "leoczanetti@gmail.com");
            contactList.Add("Nilva Martins do Nascimento", "nilvafloreira@gmail.com");
            contactList.Add("Fernando Moreira Braga", "frtnandogalobraga@gmail.com");
            contactList.Add("Luiz Fernando de Oliveira Gonçalves", "fer1goncalves@gmail.com");
            contactList.Add("ELITERIO CANISIO HERBERT", "altaircanisiohertz@hotmail.com");
            contactList.Add("Janderson do Nascimento pereira", "jandersonnp@hotmail.com");
            contactList.Add("Elves Gonçalves Lima", "elveslima17@gmail.com");
            contactList.Add("Ilceny Maria Aparecida Almeida", "ilcenym@gmail.com");
            contactList.Add("Michel Luiz dos Santos Pereira", "tradermcl@gmail.com");
            contactList.Add("Lucas Mateus Borges dos Santos", "lmateusborgesdossantos@gmail.com");
            contactList.Add("Thiago de Oliveira Aguilera Higa", "higa_thiago@hotmail.com");
            contactList.Add("Paulo do Carmo Rosa De Almeida", "paulinhofinancas@gmail.com");
            contactList.Add("Felipe Boni Jacoboski", "felipejacoboski12@hotmail.com");
            contactList.Add("Lucas de Souza Marquesa", "lucassouzam2010@gmail.com");
            contactList.Add("Leonardo Barbosa Menezes", "leonardo.barbosa.m37@gmail.com");
            contactList.Add("Matheus Carvalho Ronzani", "mronzani1991@gmail.com");
            contactList.Add("Andreson de Almeida", "andresonalmeida.aaa@gmail.com");
            contactList.Add("Carlos Hermes", "carloshermes32@gmail.com");
            contactList.Add("Marcelo Fregoneze", "marcelo_fregoneze@hotmail.com");
            contactList.Add("Valdecir Dreher", "dreherval@gmail.com");
            contactList.Add("Diogo Maia Azevedo", "diegoazevedo823@gmail.com");
            contactList.Add("ocimar aparecido lisboa", "ocimaraplisboa@hotmail.com");
            contactList.Add("EUGENIO MARTINELLI", "foimartinelli@gmail.com");
            contactList.Add("Vitor Abel de Alcântara dos Santos", "vitor.abel77@gmail.com");
            contactList.Add("Roberto Rodrigues Costa", "atitudemodamaior@hotmail.com");
            contactList.Add("Rafael Santos Pereira", "rafa_pereira7@hotmail.com");
            contactList.Add("David Anderson da Silva", "da3922706@gmail.com");
            contactList.Add("Melquisedeque Welson Dos Anjos", "melquisedequewelson@gmail.com");
            contactList.Add("Gilcimar santana", "gilcimarsantana@hotmail.com");
            contactList.Add("LUIZ HENRIQUE DE SOUSA MOREIRA", "luizherinque.moreira10@gmail.com");
            contactList.Add("Jefferson de Sousa vaes", "jeffersonvaissousa@gmail.com");
            contactList.Add("Alberson Ribeiro Bruno", "arbruno@bol.com.br");
            contactList.Add("italo uchoa oliveira", "98iuchoa@gmail.com");
            contactList.Add("Antonio Augusto da Silveira Muniz", "gustosilveira@hotmail.com");
            contactList.Add("Cayan das Neves de Mello_", "cayanneves@gmail.com");
            contactList.Add("André Luiz fadanni", "andrefadanni@icloud.com");
            contactList.Add("CRISTINA ALBUQUERQUE DOUBERIN", "cristinaadouberin@hotmail.com");
            contactList.Add("Bruno de Souza Barreto", "brunobarretto01@gmail.com");
            contactList.Add("Josias Mendonça Ramos Júnior", "mendoonca.jr@hotmail.com");
            contactList.Add("Joice Christ", "joice_christ00@hotmail.com");
            contactList.Add("Wellington candido da Silva", "wellingtonsilvinha001@gmail.com");
            contactList.Add("Rodrigo de Queiroz da Costa", "rodrigoqdacosta@gmail.com");
            contactList.Add("Bruno wilker Teixeira Leal", "brunowilker009@gmail.com");
            contactList.Add("Aron matheus alencar da silva", "matheusalencar3840@gmail.com");
            contactList.Add("SAMUEL AMANCIO MOREIRA", "samuelgvicm@hotmail.com");
            contactList.Add("Thiago Rafael da Silva", "silva_thiago@hotmail.com");
            contactList.Add("GUILHERME LIDEME DE CASTILHO", "guiihxbox@gmail.com");
            contactList.Add("Yan Souza de Oliveira", "oliveira.357@outlook.com");
            contactList.Add("Leandro Henrique Dorighetti Cavalcanti", "leandro.dorighetti@gmail.com");
            contactList.Add("Vinícius pinto de Rezende", "vprezende@gmail.com");
            contactList.Add("Jorge Teodoro de Oliveira Júnior", "juniorxt660@outlook.com");
            contactList.Add("Sidnei Francisco do nascimento Júnior", "sdineij@gmail.com");
            contactList.Add("Rafael Henrique Ochiliski Gern", "rafagern@gmail.com");
            contactList.Add("Paulo Santiego Vieira", "paulosantiego@gmail.com");
            contactList.Add("Felipe Laurentino Carlos", "fe.park@hotmail.com");
            contactList.Add("iara dos santos freitas", "santosfreitasiara@gmail.com");
            contactList.Add("João Paulo Lopes de Souza", "jp.joaopaulo1612@gmail.com");
            contactList.Add("Roberto Guimarães de Oliveira Nascimento", "robertoguimaraes48@hotmail.com");
            contactList.Add("Abraão Fortes De Carvalho", "carvalhoabraao744@gmail.com");
            contactList.Add("Douglas Mendonça de Lima", "douglasmendrp@hotmail.com");
            contactList.Add("José Gustavo Lima", "gustahjr@gmail.com");
            contactList.Add("Natan Gabriel Beilfuss", "natanbeilfuss@outlook.com");
            contactList.Add("joao pedro fontes ferraretto", "jp@ferrarettohotel.com.br");
            contactList.Add("Carla Patrícia Nucci Bueno", "raphael_nucci@yahoo.com.br");
            contactList.Add("Lucas Ramon Rohr", "lucas_rohr96@hotmail.com");
            contactList.Add("Diego Pires Muller", "diego3446muller@gmail.com");
            contactList.Add("Marianne Joya Viera", "joyamelo2000@gmail.com");
            contactList.Add("Kauan costa santos", "skauan459@gmail.com");
            contactList.Add("victor cristiano pereira barreto", "hugo.torquato11@hotmail.com");
            contactList.Add("Gregory Barros Oliveira", "gregorytrader21@gmail.com");
            contactList.Add("MANOEL DUMKE RAUGUST", "manoeldumke@gmail.com");
            contactList.Add("KARTHEN J R CHAVES", "karthen.junior@gmail.com");
            contactList.Add("Thales Santana", "thaleseq@gmail.com");
            contactList.Add("Joao Francisco Prates Junior", "johnny.fernandes45@gmail.com");
            contactList.Add("Valdir Domingos de Araujo", "viniaraujo1114@gmail.com");
            contactList.Add("Robson Brandão Nogueira", "robson.brandao@outlook.com");
            contactList.Add("Weslley Henrique Alves Ferreira", "weslleyhenriquealves@hotmail.com");
            contactList.Add("Matheus Gabriel Menghi Soder", "m.soder2508@gmail.com");
            contactList.Add("Rafael Azevedo Santana", "rafael_santana89@hotmail.com");
            contactList.Add("Higor Henrique Moreira Cruz", "higao12henrique@gmail.com");
            contactList.Add("Bruno Deodilio de Macedo Santos", "bruno-santos11@hotmail.com");
            contactList.Add("Marcos Daniel Rusch", "ruschinho@hotmail.com");
            contactList.Add("marcos daniel nardini", "marcos_mdn@outlook.com");
            contactList.Add("Paulo Henrique Martins Ferreira", "fiotph14@gmail.com");
            contactList.Add("Agnaldo Rael Rodrigues Junior", "agnaldorrj00@gmail.com");
            contactList.Add("Matheus name amaral", "matheus2504@live.com");
            contactList.Add("Jefferson Nunes leite", "jeffersonnl1993@gmail.com");
            contactList.Add("Rudson Aylan Soares ribeiro", "rudsonaylan95@gmail.com");
            contactList.Add("Hércules de araujo borges", "dinheirodolar93@gmail.com");
            contactList.Add("Thyago de Oliveira", "ubimed1@hotmail.com");
            contactList.Add("Giovanni Graciano Vasconcelos", "giovanni.graciano.gg@gmail.com");
            contactList.Add("Fernanda Hofke da Costa", "hofke78@hotmail.com");
            contactList.Add("Matheus ferreira Nunes Silva", "matheusferreiragu2@gmail.com");
            contactList.Add("Tharlles Andrade de Melo", "tharlles_mello@hotmail.com");
            contactList.Add("Fábio de Sousa Nascimento", "sousafabio758@gmail.com");
            contactList.Add("Lucas Tadeu Silva Melo", "andreirairdes@hotmail.com");
            contactList.Add("Frederico jose lima braga leal", "fredericojoseleal@gmail.com");
            contactList.Add("Wallace oliveira Machado", "machadowallace15@gmail.com");
            contactList.Add("Edson Pablo", "edsonpablo23@gmail.com");
            contactList.Add("marcos Rogerio Nogueira Das Chagas Oliveiras", "canalpaoqueijo2@gmail.com");
            contactList.Add("Haroldo Gondim Torres Neto", "haroldogondim@hotmail.com");
            contactList.Add("André Matos de oliveira", "andre22matos@gmail.com");
            contactList.Add("Joao luis Silva Calabres", "joao4luis5@gmail.com");
            contactList.Add("André Luiz Sete", "sete.andre@hotmail.com");
            contactList.Add("matheus de oliveira souza", "matheusjs1997@gmail.com");
            contactList.Add("Luiz Antônio da Silva Ferrari Braga", "luiz.ferrari.braga@hotmail.com");
            contactList.Add("Jiniane Souza Santos", "santiago.o113@outlook.com");
            contactList.Add("Lucas araujo da cunha", "lukinhasarau@gmail.com");
            contactList.Add("Hamilton de Souza Júnior", "hamilton.trader1809@gmail.com");
            contactList.Add("Jaime Anastácio Verçosa Neto", "jaimevercosa@gmail.com");
            contactList.Add("Adriano Elias Monteiro Silva e Silva", "adrianoeliasms@gmail.com");
            contactList.Add("Maria de Fátima dos santos", "euescolhivaroar2000@gmail.com");
            contactList.Add("Lucas barcellos cesar", "lucas.bc@hotmail.com");
            contactList.Add("Luiz Gustavo Vieira de Freitas", "lgvf007@gmail.com");
            contactList.Add("Valto Gomes Pereira", "valtinho2007@outlook.com");
            contactList.Add("Sadi Antonio de Araujo Junior", "sadi.junior.rs@hotmail.com");
            contactList.Add("Anderson dos santos", "anderson8213@hotmail.com");
            contactList.Add("Felipe Nogueira", "felipe.tch@hotmail.com");
            contactList.Add("Rodrigo Dos Santos Oliveira", "rodrigoedry@hotmail.com");
            contactList.Add("dennis moura monteiro", "dennismmoura97@gmail.com");
            contactList.Add("Artur Graçano Ribeiro", "gracano2@gmail.com");
            contactList.Add("Wagner Dionisio Correia", "wagner-santa@hotmail.com");
            contactList.Add("Ronaldo Valença dos Santos", "ronyvalsan@gmail.com");
            contactList.Add("Lucas Vinícius Ferreira da Silva", "lucasvf536@gmail.com");
            contactList.Add("Bruno Marques Sales", "bruno.m.sales@hotmail.com");
            contactList.Add("Yan Marcos Pavi", "pocketpavi@gmail.com");
            contactList.Add("David Anderson da Silva_", "dd360110@gmail.com");
            contactList.Add("williane lima da silva", "vantusoficial2020@gmail.com");
            contactList.Add("angela maria pastor santana", "angelamaria363836@gmail.com");
            contactList.Add("Luccas do Carmo Silva", "luccas_cdc@hotmail.com");
            contactList.Add("PABLO VAGNER DIAS DOS REIS", "pablovddr@gmail.com");
            contactList.Add("Rosemberg Passos da Costa", "bergfj@hotmail.com");
            contactList.Add("Alex Laquiman Faria", "alex.laquiman51@gmail.com");
            contactList.Add("Pedro Moraes Iunes", "pedrinhoiunes@gmail.com");
            contactList.Add("Anderson de Oliveira Cabral", "anderson.ocabral@gmail.com");
            contactList.Add("Orlei Moreira Santos", "orleimonetizze001@gmail.com");
            contactList.Add("Andrew de Mello martinez", "andrewmello.engcivil@gmail.com");
            contactList.Add("Carlos Juan Lima", "carlosjuanlima7@icloud.com");
            contactList.Add("Vanderson Juninho Soares", "vanderson-botu@hotmail.com");
            contactList.Add("Naidson Gama dos Santos", "nulo.net@gmail.com");
            contactList.Add("Emanoel dos Santos Pereira", "emanueltrader1.et544@gmail.com");
            contactList.Add("Pedro Henrique Gonçalves Andrade", "pedrodocruzeiro123@hotmail.com");
            contactList.Add("Gabriel dias de oliveira", "gabrielsanfamily@gmail.com");
            contactList.Add("Sergio de Mello", "sergio@ishisupuma.com.br");
            contactList.Add("Alex Luan Sepulveda Suque", "alexsuque18k@gmail.com");
            contactList.Add("Adriano gramlich Fernandes", "adriano.adriard@gmail.com");
            contactList.Add("Ronei baldoria Silverio", "ronei_jts90@hotmail.com");
            contactList.Add("Nicolas Cristian Silveira Batista", "nicolascristian007@gmail.com");
            contactList.Add("WENICIUS ANTONIO DA CONCEIÇÃO", "w.melhoramentos@gmail.com");
            contactList.Add("Alessandra Maciel Ferreira", "luizcarlosribeiro198@gmail.com");
            contactList.Add("Roselane Gomes de Andrade", "laynegomes@hotmail.com");
            contactList.Add("Rodolfo ramos Lopes da Silva", "rodolforamos2017@gmail.com");
            contactList.Add("Luan Carlos Oliveira de Aquino", "aquinoinvestimento@gmail.com");
            contactList.Add("Marcos Wenderson Moreira da Costa", "marcoswenderson241@gmail.com");
            contactList.Add("Jose geraldo maciel", "gera123trader@gmail.com");
            contactList.Add("João Victor Da Rocha Pequeno", "joao.rochapeq@gmail.com");
            contactList.Add("Ulisses Damacena Ribeiro Silva lobo", "ulissesdamacena@gmail.com");
            contactList.Add("Pedro Gabriel Martins policarpo stumm", "pedrostummfilms@gmail.com");
            contactList.Add("Leonardo Ribeiro Aquino", "leo_aquino@msn.com");
            contactList.Add("Elisson Salgado Barros", "salgado.elisson@gmail.com");
            contactList.Add("Jaime Almeida dos Santos", "jaime.almeida998@gmail.com");
            contactList.Add("João Omar Correia neto", "joaoomarneto@gmail.com");
            contactList.Add("Rafael Anderson da Silva", "rafaelsilvajf06@gmail.com");
            contactList.Add("Rafael Alencar Teixeira", "rafaelalencart@gmail.com");
            contactList.Add("Juan de Oliveira felix", "juandeoliveirafeliiix@gmail.com");
            contactList.Add("Carolina Grassmann", "grass.c@hotmail.com");
            contactList.Add("Bruno Borges", "brunofla27@gmail.com");
            contactList.Add("Greiciely Mangini de Castro", "greiciely.mangini@gmail.com");
            contactList.Add("Pedro Igor Rodrigues Lima", "pedroigorr13@gmail.com");
            contactList.Add("Matheus Ferreira de Assis", "homempeixe202@gmail.com");
            contactList.Add("Matheus da costa morais", "theuskateordie@hotmail.com");
            contactList.Add("Cayan das Neves de Mello", "theuskateordie@hotmail.com");
            contactList.Add("Tiago Vitor de Almeida", "tiago.almeida110833@gmail.com");
            contactList.Add("Fernando Calmon Figueiredo", "facilclube@gmail.com");
            contactList.Add("Rogério Vinicius de Jesus Duarte", "rvjdu1@gmail.com");
            contactList.Add("Matheus menezes vinagreiro", "matheus.vinagreiro03@gmail.com");
            contactList.Add("Matheus Bueno Lima", "matheusbuenolima@gmail.com");
            contactList.Add("Jailson Marques Almondes Sousa", "jailsonmarques75@gmail.com");
            contactList.Add("Mauro de oliveira Salgado", "mauro.elaine@hotmail.com");
            contactList.Add("ighor Abraão gerlani Gonçalves de Carvalho", "ighor.ab22@icloud.com");
            contactList.Add("gabriel oliveira dias", "gabrieljesusdias001@gmail.com");
            contactList.Add("Bruno Hudson Gomes Lourenço", "brunohudson581@gmail.com");
            contactList.Add("Natália de Faria Faleiros", "nataliafaria000@gmail.com");
            contactList.Add("Cesar augusto ramirez bustos", "cesaramirez6996@gmail.com");
            contactList.Add("Gabriel Janousek", "gabrieljanousek@gmail.com");
            contactList.Add("Suziléa Andréa Leal do Prado", "suzilea.prado@hotmail.com");
            contactList.Add("Christian da Silva Paim", "paimchristian07@gmail.com");
            contactList.Add("Marllon eriky theodoro machado", "marlloneriky15@gmail.com");
            contactList.Add("Jonathan Alves Conde", "jon.ffc@icloud.com");
            contactList.Add("MARCIO ARAUJO FERREIRA E ALMEIDA", "araujomarcio60@gmail.com");
            contactList.Add("João paulo aparecido lima", "jplimadiamante@gmail.com");
            contactList.Add("Rodrigo Nunes Loureiro", "rn01904@gmail.com");
            contactList.Add("Vinicius silveira de gois", "vinigois8@outlook.com");
            contactList.Add("Diego da Silva", "diegogas10@gmail.com");
            contactList.Add("PEDRO BARRETO NETO", "pedrobarretoneto@yahoo.com.br");
            contactList.Add("Rodrigo Ferreira dos Santos", "rodrigoferreirasantos58@gmail.com");
            contactList.Add("Otavio Luiz Assis dos Prazeres", "oluiz047@gmail.com");
            contactList.Add("Antônio Carlos da Silva Araújo", "cabeca.r7@gmail.com");
            contactList.Add("Jardel de Sousa forte Teixeira", "jardel_20@yahoo.com.br");
            contactList.Add("Leandro Ribeiro Marcos", "leandro_ribeirvo_marcos@hotmail.com");
            contactList.Add("Allyson Nascimento Guimarães", "allyson.otaku1@gmail.com");
            contactList.Add("Shelton Rezende", "sheltonrezende10@gmail.com");
            contactList.Add("Erica dos Santos Bezerra", "erikaadossantos@gmail.com");
            contactList.Add("GILSON FREITAS DIAS", "gfdiascontabilidade@gmail.com");
            contactList.Add("Alessandro Magalhães de Almeida", "magalhaesproducoes@outlook.com");
            contactList.Add("Natanael Guimarães", "nata.silva10@gmail.com");
            contactList.Add("André Kaizer Souza", "andrekaizer1997@gmail.com");
            contactList.Add("Dionatas Boita Veiga", "dionboita@gmail.com");
            contactList.Add("Rafael Oliveira Farias", "rafa.oliveirafarias@outlook.com");
            contactList.Add("Antônio Humberto de Sousa Silva", "digitall.contas@gmail.com");
            contactList.Add("Lucas Matheus Romão Leal", "lucasmrleal@gmail.com");
            contactList.Add("Omar de Oliveira Osório Neto", "netoomar447@gmail.com");
            contactList.Add("Everton dos santos nunes", "evertonnunes425@gmail.com");
            contactList.Add("Marcelo Alves Marques", "malvesmarques@gmail.com");
            contactList.Add("Flater Junio Germano", "flaterjunior@gmail.com");
            contactList.Add("Felipe Alves galvao", "felipegalvao8901@gmail.com");
            contactList.Add("FRANCIS WILLIAN DA SILVA CARDOSO", "contato.nmrkprodutos@gmail.com");
            contactList.Add("Lucas Oliveira de Souza", "lucasdark01@gmail.com");
            contactList.Add("Guilherme Fernandes coelho", "guilhermefcoelho@hotmail.com");
            contactList.Add("Matheus Silva Campos", "campos.mat01@gmail.com");
            contactList.Add("MARIZELE ALMEIDA DE SOUSA", "marizelealmeidadesousa@gmail.com");
            contactList.Add("MICHELA DA SILVA COSTA", "michelascosta.adv@gmail.com");
            contactList.Add("Agenor Pereira da Silva Neto", "elinor.mtm@gmail.com");
            contactList.Add("Gabriel Fernando Pires Carvalho", "checkpointbrasil0@gmail.com");
            contactList.Add("João Lucas Marques Alves", "jlmalves2017@gmail.com");
            contactList.Add("Miguel Oliveira do Rego", "contato.miguel190@icloud.com");
            contactList.Add("Francesco toschi incerti", "incerti56@gmail.com");
            contactList.Add("Carlos Eduardo Pinho Neto Figueiredo", "ceneto93@hotmail.com");
            contactList.Add("Eduardo Domingos Morais Araujo", "0705.araujo.1327@gmail.com");
            contactList.Add("Leonardo Duarte Sa", "leosa4@hotmail.com");
            contactList.Add("Marcilio Bruno Ventura", "marciliobruno5@gmail.com");
            contactList.Add("Francisco de Assis Costa Filho", "segundinho2013@gmail.com");
            contactList.Add("Luan Gonçalves campista", "luancampista36@gmail.com");
            contactList.Add("Jhonatan De Aguiar Silva", "jhonatanaguiar013@hotmail.com");
            contactList.Add("César Henrique da Conceição Figueiredo", "cesarhenriquec507@gmail.com");
            contactList.Add("Lucas Santos", "lucas.santosfsa@gmail.com");
            contactList.Add("Gabriel Domingos de Assis", "domingos.gabriel2010@hotmail.com");
            contactList.Add("Flori Sobrinho", "engenharia.geox@gmail.com");
            contactList.Add("João Tadeu do Carmo Junior", "jtjacui@yahoo.com.br");
            contactList.Add("joao vitor alves da silva", "joaovitoralvesover@gmail.com");
            contactList.Add("Francisco Carlos Marques Barbosa", "carlosmagnum1@yahoo.com.br");
            contactList.Add("Valdoir Andretta", "valdoirproooz1nnandretta@gmail.com");
            contactList.Add("Pedro Ivo Souza Ramos", "pedroivoinveste2019@gmail.com");
            contactList.Add("Thiago Henrique Almeida Ribas", "thiago.hribas@gmail.com");
            contactList.Add("Joao luis gomes da silva", "joao.confraria@gmail.com");
            contactList.Add("Maurício Fernandes Machado", "mauricio.fmachado@outlook.com");
            contactList.Add("Julio Magalhães", "julitomagalhaes@gmail.com");
            contactList.Add("David Felipe Soares", "davidfelsoares@gmail.com");
            contactList.Add("MARIA BERENICE ZANANDREA", "estevanportolan123@gmail.com");
            contactList.Add("Amanda Pereira da Cunha", "renanramalho74@gmail.com");
            contactList.Add("Diego Oliveira felix", "diegodavilucas2019@gmail.com");
            contactList.Add("Gabriel Teixeira", "gp291338@gmail.com");
            contactList.Add("Duane Fernanda Conceição Teixeira", "duanefc@outlook.com");
            contactList.Add("Darley Wagner Magalhães Ribeiro Junior", "dwjunior26on@gmail.com");
            contactList.Add("JONATHAS DE MELO CHAGAS", "jonathasdemelochagas@gmail.com");
            contactList.Add("Vinícius Rodrigo de Almeida Silva", "vinicius_rodrigo10@hotmail.com");
            contactList.Add("Juan Pereira Freire", "juan.freire.397@gmail.com");
            contactList.Add("Ricardo Carvalho lima", "ranchoaloisiolima@yahoo.com.br");
            contactList.Add("Gabriel Dias Nocce", "gabriel.diasnocce@gmail.com");
            contactList.Add("Luana Pires muller", "luhmuller2001@gmail.com");
            contactList.Add("Helder Henrique Soares de freitas", "helder10freitas@gmail.com");
            contactList.Add("Felipe Gabriel Ferreira Winter", "fehnalle@gmail.com");
            contactList.Add("WAGNER NERY", "juniorwagner485@gmail.com");
            contactList.Add("Natanael Ferreira da Silva", "fnatanael678@gmail.com");
            contactList.Add("Marcelo Bertinatto D' Onofrio", "marcelobertinatto@hotmail.com");

            return contactList;
        }
    }
}
