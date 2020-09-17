using System;
using FachadaUniversidad.salones;

namespace FachadaUniversidad.Reservas
{
    public class Reservar
    {
        #region Properties
        public string Nombre { get; set; }
        public string OpcionUsuario { get; set; }
        public float temperaturaSalon { get; set; }
        public string estadoSalon { get; set; }
        public bool estadopuertas { get; set; }


        //contraseñas:
        int contraseñaUsuario1 = 12345;
        int contraseñaUsuario2 = 6789;

        //salones:

        //salon1
        string salon1_7am="libre";
        string salon1_8am="libre";
        string salon1_9am="libre";
        string salon1_10am="libre";
        string salon1_11am="libre";
        string salon1_12pm="libre";
        string salon1_1pm="libre";
        string salon1_2pm="libre";
        string salon1_3pm="libre";
        string salon1_4pm="libre";
        string salon1_5pm="libre";
        string salon1_6pm="libre";
        string salon1_7pm="libre";

        //salon2
        string salon2_7am="libre";
        string salon2_8am="libre";
        string salon2_9am="libre";
        string salon2_10am="libre";
        string salon2_11am="libre";
        string salon2_12pm="libre";
        string salon2_1pm="libre";
        string salon2_2pm="libre";
        string salon2_3pm="libre";
        string salon2_4pm="libre";
        string salon2_5pm="libre";
        string salon2_6pm="libre";
        string salon2_7pm="libre";

        //salon3
        string salon3_7am="libre";
        string salon3_8am="libre";
        string salon3_9am="libre";
        string salon3_10am="libre";
        string salon3_11am="libre";
        string salon3_12pm="libre";
        string salon3_1pm="libre";
        string salon3_2pm="libre";
        string salon3_3pm="libre";
        string salon3_4pm="libre";
        string salon3_5pm="libre";
        string salon3_6pm="libre";
        string salon3_7pm="libre";


        #region Methods
        public void SaludarCliente()
        {
            Console.WriteLine("Bienvenido a la agenda de reserva de salones\n ");
            Console.WriteLine("Por favor selecciona un usuario ");
            Menu();
        }


        public void Menu()
        {
            Console.WriteLine("Los usuarios predeterminados son: \n1-) Usuario1 \n2-) usuario2");
            OpcionUsuario = Console.ReadLine();
            if(OpcionUsuario == "1")
            {
                ValidarContraseña();
            }
            if(OpcionUsuario == "2"){
                ValidarContraseña();
            }
        }

        private void ValidarContraseña()
        {
            bool contraseña = false;
            while(contraseña==false){
                Console.WriteLine("digita tu contraseña: ");
                int contraseñaDigitada = int.Parse(Console.ReadLine());
                if(contraseñaUsuario1==contraseñaDigitada && OpcionUsuario == "1")
                {
                    contraseña = true;
                    Console.WriteLine("Bienvenido usuario 1 ");
                    Menu2();

                }
                else if(contraseñaUsuario2==contraseñaDigitada && OpcionUsuario == "2")
                {
                    contraseña = true;
                    Console.WriteLine("Bienvenido usuario 2 ");
                    Menu2();

                }
                else
                {
                    Console.WriteLine("contraseña incorrecta ");
                    contraseña = false;
                }
            }
            
        }

        public void Menu2()
        {
            Console.WriteLine("selecciona una opcion a realizar: \n1-) lista de salones \n2-) reservar\n3-) cancelar reserva \n4-) mantenimiento \n5-) cancelar mantenimiento \n6-) Iniciar una clase \n0-) Salir");
            OpcionUsuario = Console.ReadLine();
            while(OpcionUsuario != "0"){
                if(OpcionUsuario == "1")
                {
                    listaSalones();
                }
                else if(OpcionUsuario == "2"){
                    reservar();
                }
                else if(OpcionUsuario =="3"){
                    cancelarReserva();
                }
                else if(OpcionUsuario == "4"){
                    Mantenimiento();
                }
                else if(OpcionUsuario == "5"){
                    cancelarMantenimiento();
                }
              else if(OpcionUsuario == "6"){
                iniciarClase();
              }
            }
        }




        public void listaSalones(){
            Console.WriteLine("Estos salones son con los que cuentan la institucion: \n1-) salon 1 \n2-) salon 2\n3-) salon 3 \n0-) devolverse al menu principal");
            OpcionUsuario = Console.ReadLine();
            while(OpcionUsuario == "0"){
                Menu2();
            }

        }
        public void reservar(){
            Console.WriteLine("Que salon deseas reservar: \n1-) salon 1 \n2-) salon 2\n3-) salon 3\n0-)Regresar al menu");
            OpcionUsuario = Console.ReadLine();
            if(OpcionUsuario=="1"){
                reservarMenuSalon1();
            }
            else if(OpcionUsuario=="2"){
                reservarMenuSalon2();
            }
            else if(OpcionUsuario=="3"){
                reservarMenuSalon3();
            }
             else if(OpcionUsuario=="0"){
                Menu2();
            }
        }
//reservar salon 1
        public void reservarMenuSalon1(){
            Console.WriteLine("Que horario deseas reservar: \n1-) 7am \n2-) 8am \n3-) 9am\n4-) 10am \n5-) 11am \n6-) 12am\n7-) 1pm \n8-) 2pm\n9-) 3pm\n10-) 4pm \n11-) 5pm \n12-) 6pm \n13-) 7pm");
            OpcionUsuario = Console.ReadLine();
            bool reservador = false;
            while(reservador == false ){
                if(OpcionUsuario=="1"){
                    if(salon1_7am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_7am="reservado";
                        reservador = true;
                    }
                    else if(salon1_7am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_7am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="2"){
                    if(salon1_8am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_8am="reservado";
                        reservador = true;
                    }
                    else if(salon1_8am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_8am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="3"){
                    if(salon1_9am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_9am="reservado";
                        reservador = true;
                    }
                    else if(salon1_9am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_9am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }
                }
                else if(OpcionUsuario=="4"){
                    if(salon1_10am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_10am="reservado";
                        reservador = true;
                    }
                    else if(salon1_10am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_10am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="5"){
                    if(salon1_11am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_11am="reservado";
                        reservador = true;
                    }
                    else if(salon1_11am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_11am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="6"){
                    if(salon1_12pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_12pm="reservado";
                        reservador = true;
                    }
                    else if(salon1_12pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_12pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="7"){
                    if(salon1_1pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_1pm="reservado";
                        reservador = true;
                    }
                    else if(salon1_1pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_1pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="8"){
                    if(salon1_2pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_2pm="reservado";
                        reservador = true;
                    }
                    else if(salon1_2pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_2pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="9"){
                    if(salon1_3pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_3pm="reservado";
                        reservador = true;
                    }
                    else if(salon1_3pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_3pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="10"){
                    if(salon1_4pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_4pm="reservado";
                        reservador = true;
                    }
                    else if(salon1_4pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_4pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="11"){
                    if(salon1_5pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_5pm="reservado";
                        reservador = true;
                    }
                    else if(salon1_5pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_5pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="12"){
                    if(salon1_6pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_6pm="reservado";
                        reservador = true;
                    }
                    else if(salon1_6pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }else if(salon1_6pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="13"){
                    if(salon1_7pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon1_7pm="reservado";
                        reservador = true;
                    }
                    else if(salon1_7pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon1_7pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
              
            }

        }
//reservar salon 2
        public void reservarMenuSalon2(){
            Console.WriteLine("Que horario deseas reservar: \n1-) 7am \n2-) 8am \n3-) 9am\n4-) 10am \n5-) 11am \n6-) 12am\n7-) 1pm \n8-) 2pm\n9-) 3pm\n10-) 4pm \n11-) 5pm \n12-) 6pm \n13-) 7pm");
            OpcionUsuario = Console.ReadLine();
            bool reservador = false;
            while(reservador == false ){
                if(OpcionUsuario=="1"){
                    if(salon2_7am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_7am="reservado";
                        reservador = true;
                    }
                    else if(salon2_7am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_7am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="2"){
                    if(salon2_8am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_8am="reservado";
                        reservador = true;
                    }
                    else if(salon2_8am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_8am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="3"){
                    if(salon2_9am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_9am="reservado";
                        reservador = true;
                    }
                    else if(salon2_9am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_9am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }
                }
                else if(OpcionUsuario=="4"){
                    if(salon2_10am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_10am="reservado";
                        reservador = true;
                    }
                    else if(salon2_10am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_10am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="5"){
                    if(salon2_11am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_11am="reservado";
                        reservador = true;
                    }
                    else if(salon2_11am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_11am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="6"){
                    if(salon2_12pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_12pm="reservado";
                        reservador = true;
                    }
                    else if(salon2_12pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_12pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="7"){
                    if(salon2_1pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_1pm="reservado";
                        reservador = true;
                    }
                    else if(salon2_1pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_1pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="8"){
                    if(salon2_2pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_2pm="reservado";
                        reservador = true;
                    }
                    else if(salon2_2pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_2pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="9"){
                    if(salon2_3pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_3pm="reservado";
                        reservador = true;
                    }
                    else if(salon2_3pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_3pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="10"){
                    if(salon2_4pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_4pm="reservado";
                        reservador = true;
                    }
                    else if(salon2_4pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_4pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="11"){
                    if(salon2_5pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_5pm="reservado";
                        reservador = true;
                    }
                    else if(salon2_5pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_5pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="12"){
                    if(salon2_6pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_6pm="reservado";
                        reservador = true;
                    }
                    else if(salon2_6pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_6pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="13"){
                    if(salon2_7pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon2_7pm="reservado";
                        reservador = true;
                    }
                    else if(salon2_7pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon2_7pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
            }

        }
//reservar salon 3
        public void reservarMenuSalon3(){
            Console.WriteLine("Que horario deseas reservar: \n1-) 7am \n2-) 8am \n3-) 9am\n4-) 10am \n5-) 11am \n6-) 12am\n7-) 1pm \n8-) 2pm\n9-) 3pm\n10-) 4pm \n11-) 5pm \n12-) 6pm \n13-) 7pm");
            OpcionUsuario = Console.ReadLine();
            bool reservador = false;
            while(reservador == false ){
                if(OpcionUsuario=="1"){
                    if(salon3_7am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_7am="reservado";
                        reservador = true;
                    }
                    else if(salon3_7am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_7am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="2"){
                    if(salon3_8am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_8am="reservado";
                        reservador = true;
                    }
                    else if(salon3_8am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_8am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="3"){
                    if(salon3_9am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_9am="reservado";
                        reservador = true;
                    }
                    else if(salon3_9am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_9am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }
                }
                else if(OpcionUsuario=="4"){
                    if(salon3_10am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_10am="reservado";
                        reservador = true;
                    }
                    else if(salon3_10am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_10am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="5"){
                    if(salon3_11am=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_11am="reservado";
                        reservador = true;
                    }
                    else if(salon3_11am=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_11am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="6"){
                    if(salon3_12pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_12pm="reservado";
                        reservador = true;
                    }
                    else if(salon3_12pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_12pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="7"){
                    if(salon3_1pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_1pm="reservado";
                        reservador = true;
                    }
                    else if(salon3_1pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_1pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="8"){
                    if(salon3_2pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_2pm="reservado";
                        reservador = true;
                    }
                    else if(salon3_2pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_2pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }
                }
                else if(OpcionUsuario=="9"){
                    if(salon3_3pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_3pm="reservado";
                        reservador = true;
                    }
                    else if(salon3_3pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_12pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }
                }
                else if(OpcionUsuario=="10"){
                    if(salon3_4pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_4pm="reservado";
                        reservador = true;
                    }
                    else if(salon3_4pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_4pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="11"){
                    if(salon3_5pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_5pm="reservado";
                        reservador = true;
                    }
                    else if(salon3_5pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_5pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }


                }
                else if(OpcionUsuario=="12"){
                    if(salon3_6pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_6pm="reservado";
                        reservador = true;
                    }
                    else if(salon3_6pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_6pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }


                }
                else if(OpcionUsuario=="13"){
                    if(salon3_7pm=="libre"){
                        Console.WriteLine("el salon se reservo correctamente");
                        salon3_7pm="reservado";
                        reservador = true;
                    }
                    else if(salon3_7pm=="reservado"){
                        Console.WriteLine("el salon ya estaba reservado por alguien");
                        reservador = true;
                    }
                    else if(salon3_7pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }


                }
            }

        }
        public void cancelarReserva(){
            Console.WriteLine("Que salon deseas reservar: \n1-) salon 1 \n2-) salon 2\n3-) salon 3");
            OpcionUsuario = Console.ReadLine();
            if(OpcionUsuario=="1"){
                cancelarReservaMenuSalon1();
            }
            else if(OpcionUsuario=="2"){
                cancelarReservaMenuSalon2();
            }
            else if(OpcionUsuario=="3"){
                cancelarReservaMenuSalon3();
            }
            else if(OpcionUsuario=="0"){
                Menu2();
            }
        }
        public void cancelarReservaMenuSalon1(){
            Console.WriteLine("Que horario deseas cancelar la reserva: \n1-) 7am \n2-) 8am \n3-) 9am\n4-) 10am \n5-) 11am \n6-) 12am\n7-) 1pm \n8-) 2pm\n9-) 3pm\n10-) 4pm \n11-) 5pm \n12-) 6pm \n13-) 7pm");
            OpcionUsuario = Console.ReadLine();
            bool reservador = false;
            while(reservador == false ){
                if(OpcionUsuario=="1"){
                    if(salon1_7am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_7am="libre";
                        reservador = true;
                    }
                    else if(salon1_7am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_7am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="2"){
                    if(salon1_8am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_8am="libre";
                        reservador = true;
                    }
                    else if(salon1_8am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_8am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="3"){
                    if(salon1_9am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_9am="libre";
                        reservador = true;
                    }
                    else if(salon1_9am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_9am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }
                }
                else if(OpcionUsuario=="4"){
                    if(salon1_10am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_10am="libre";
                        reservador = true;
                    }
                    else if(salon1_10am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_10am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="5"){
                    if(salon1_11am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_11am="libre";
                        reservador = true;
                    }
                    else if(salon1_11am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_11am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="6"){
                    if(salon1_12pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_12pm="libre";
                        reservador = true;
                    }
                    else if(salon1_12pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_12pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="7"){
                    if(salon1_1pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_1pm="libre";
                        reservador = true;
                    }
                    else if(salon1_1pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_1pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="8"){
                    if(salon1_2pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_2pm="libre";
                        reservador = true;
                    }
                    else if(salon1_2pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_2pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="9"){
                    if(salon1_3pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_3pm="libre";
                        reservador = true;
                    }
                    else if(salon1_3pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_3pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="10"){
                    if(salon1_4pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_4pm="libre";
                        reservador = true;
                    }
                    else if(salon1_4pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_4pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="11"){
                    if(salon1_5pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_5pm="libre";
                        reservador = true;
                    }
                    else if(salon1_5pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_5pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="12"){
                    if(salon1_6pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_6pm="libre";
                        reservador = true;
                    }
                    else if(salon1_6pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_6pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="13"){
                    if(salon1_7pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon1_7pm="libre";
                        reservador = true;
                    }
                    else if(salon1_7pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon1_7pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
            }

        }
        public void cancelarReservaMenuSalon2(){
            Console.WriteLine("Que horario deseas cancelar la reserva: \n1-) 7am \n2-) 8am \n3-) 9am\n4-) 10am \n5-) 11am \n6-) 12am\n7-) 1pm \n8-) 2pm\n9-) 3pm\n10-) 4pm \n11-) 5pm \n12-) 6pm \n13-) 7pm");
            OpcionUsuario = Console.ReadLine();
            bool reservador = false;
            while(reservador == false ){
                if(OpcionUsuario=="1"){
                    if(salon2_7am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_7am="libre";
                        reservador = true;
                    }
                    else if(salon2_7am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_7am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="2"){
                    if(salon2_8am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_8am="libre";
                        reservador = true;
                    }
                    else if(salon2_8am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_8am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="3"){
                    if(salon2_9am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_9am="libre";
                        reservador = true;
                    }
                    else if(salon2_9am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_9am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }
                }
                else if(OpcionUsuario=="4"){
                    if(salon2_10am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_10am="libre";
                        reservador = true;
                    }
                    else if(salon2_10am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_10am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="5"){
                    if(salon2_11am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_11am="libre";
                        reservador = true;
                    }
                    else if(salon2_11am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_11am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="6"){
                    if(salon2_12pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_12pm="libre";
                        reservador = true;
                    }
                    else if(salon2_12pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_12pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="7"){
                    if(salon2_1pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_1pm="libre";
                        reservador = true;
                    }
                    else if(salon2_1pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_1pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="8"){
                    if(salon2_2pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_2pm="libre";
                        reservador = true;
                    }
                    else if(salon2_2pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_2pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="9"){
                    if(salon2_3pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_3pm="libre";
                        reservador = true;
                    }
                    else if(salon2_3pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_3pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="10"){
                    if(salon2_4pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_4pm="libre";
                        reservador = true;
                    }
                    else if(salon2_4pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_4pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="11"){
                    if(salon2_5pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_5pm="libre";
                        reservador = true;
                    }
                    else if(salon2_5pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_5pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="12"){
                    if(salon2_6pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_6pm="libre";
                        reservador = true;
                    }
                    else if(salon2_6pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_6pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="13"){
                    if(salon2_7pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon2_7pm="libre";
                        reservador = true;
                    }
                    else if(salon2_7pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon2_7pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
            }

        }
        public void cancelarReservaMenuSalon3(){
            Console.WriteLine("Que horario deseas cancelar la reserva: \n1-) 7am \n2-) 8am \n3-) 9am\n4-) 10am \n5-) 11am \n6-) 12am\n7-) 1pm \n8-) 2pm\n9-) 3pm\n10-) 4pm \n11-) 5pm \n12-) 6pm \n13-) 7pm");
            OpcionUsuario = Console.ReadLine();
            bool reservador = false;
            while(reservador == false ){
                if(OpcionUsuario=="1"){
                    if(salon3_7am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_7am="libre";
                        reservador = true;
                    }
                    else if(salon3_7am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_7am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }
                    

                }
                else if(OpcionUsuario=="2"){
                    if(salon3_8am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_8am="libre";
                        reservador = true;
                    }
                    else if(salon3_8am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_8am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="3"){
                    if(salon3_9am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_9am="libre";
                        reservador = true;
                    }
                    else if(salon3_9am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_9am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }
                }
                else if(OpcionUsuario=="4"){
                    if(salon3_10am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_10am="libre";
                        reservador = true;
                    }
                    else if(salon3_10am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_10am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="5"){
                    if(salon3_11am=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_11am="libre";
                        reservador = true;
                    }
                    else if(salon3_11am=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_11am=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="6"){
                    if(salon3_12pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_12pm="libre";
                        reservador = true;
                    }
                    else if(salon3_12pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_12pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="7"){
                    if(salon3_1pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_1pm="libre";
                        reservador = true;
                    }
                    else if(salon3_1pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_1pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="8"){
                    if(salon3_2pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_2pm="libre";
                        reservador = true;
                    }
                    else if(salon3_2pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_2pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="9"){
                    if(salon3_3pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_3pm="libre";
                        reservador = true;
                    }
                    else if(salon3_3pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_3pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="10"){
                    if(salon3_4pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_4pm="libre";
                        reservador = true;
                    }
                    else if(salon3_4pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_4pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="11"){
                    if(salon3_5pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_5pm="libre";
                        reservador = true;
                    }
                    else if(salon3_5pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_5pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="12"){
                    if(salon3_6pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_6pm="libre";
                        reservador = true;
                    }
                    else if(salon3_6pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_6pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
                else if(OpcionUsuario=="13"){
                    if(salon3_7pm=="reservado"){
                        Console.WriteLine("se cancelo la reserva correctamente");
                        salon3_7pm="libre";
                        reservador = true;
                    }
                    else if(salon3_7pm=="libre"){
                        Console.WriteLine("el salon ya estaba libre");
                        reservador = true;
                    }
                    else if(salon3_7pm=="mantenimiento"){
                        Console.WriteLine("el salon se encuentra en mantenimiento por lo tanto no se puede reservar");
                        reservador = true;
                    }

                }
            }

        }
        public void Mantenimiento(){
            Console.WriteLine("Que salon deseas poner en mantenimiento: \n1-) salon 1 \n2-) salon 2\n3-) salon 3\n0-)Para regresar al menu");
            OpcionUsuario = Console.ReadLine();
            if(OpcionUsuario=="1"){
                mantenimientoSalon1();
            }
            else if(OpcionUsuario=="2"){
                mantenimientoSalon2();
            }
            else if(OpcionUsuario=="3"){
                mantenimientoSalon3();
            }
            else if(OpcionUsuario=="0"){
                Menu2();
            }
        }

        public void mantenimientoSalon1(){
            Console.WriteLine("el salon 1 entro en mantenimiento en todos sus horarios");
            salon1_7am="mantenimiento";
            salon1_8am="mantenimiento";
            salon1_9am="mantenimiento";
            salon1_10am="mantenimiento";
            salon1_11am="mantenimiento";
            salon1_12pm="mantenimiento";
            salon1_1pm="mantenimiento";
            salon1_2pm="mantenimiento";
            salon1_3pm="mantenimiento";
            salon1_4pm="mantenimiento";
            salon1_5pm="mantenimiento";
            salon1_6pm="mantenimiento";
            salon1_7pm="mantenimiento";

        }
        public void mantenimientoSalon2(){
            Console.WriteLine("el salon 2 entro en mantenimiento en todos sus horarios");
            salon2_7am="mantenimiento";
            salon2_8am="mantenimiento";
            salon2_9am="mantenimiento";
            salon2_10am="mantenimiento";
            salon2_11am="mantenimiento";
            salon2_12pm="mantenimiento";
            salon2_1pm="mantenimiento";
            salon2_2pm="mantenimiento";
            salon2_3pm="mantenimiento";
            salon2_4pm="mantenimiento";
            salon2_5pm="mantenimiento";
            salon2_6pm="mantenimiento";
            salon2_7pm="mantenimiento";

        }
        public void mantenimientoSalon3(){
            Console.WriteLine("el salon 3 entro en mantenimiento en todos sus horarios");
            salon3_7am="mantenimiento";
            salon3_8am="mantenimiento";
            salon3_9am="mantenimiento";
            salon3_10am="mantenimiento";
            salon3_11am="mantenimiento";
            salon3_12pm="mantenimiento";
            salon3_1pm="mantenimiento";
            salon3_2pm="mantenimiento";
            salon3_3pm="mantenimiento";
            salon3_4pm="mantenimiento";
            salon3_5pm="mantenimiento";
            salon3_6pm="mantenimiento";
            salon3_7pm="mantenimiento";

        }

        public void cancelarMantenimiento(){
            Console.WriteLine("Que salon deseas poner retirar del mantenimiento: \n1-) salon 1 \n2-) salon 2\n3-) salon 3\n0-)Regresar al Menu");
            OpcionUsuario = Console.ReadLine();
            if(OpcionUsuario=="1"){
                cancelarMantenimientoSalon1();
            }
            else if(OpcionUsuario=="2"){
                cancelarMantenimientoSalon2();
            }
            else if(OpcionUsuario=="3"){
                cancelarMantenimientoSalon3();
            }
            else if(OpcionUsuario=="0"){
                Menu2();
            }
        }

        public void cancelarMantenimientoSalon1(){
            Console.WriteLine("el salon 1 se retiro del mantenimiento en todos sus horarios");
            salon1_7am="libre";
            salon1_8am="libre";
            salon1_9am="libre";
            salon1_10am="libre";
            salon1_11am="libre";
            salon1_12pm="libre";
            salon1_1pm="libre";
            salon1_2pm="libre";
            salon1_3pm="libre";
            salon1_4pm="libre";
            salon1_5pm="libre";
            salon1_6pm="libre";
            salon1_7pm="libre";

        }
        public void cancelarMantenimientoSalon2(){
            Console.WriteLine("el salon 2 se retiro del mantenimiento en todos sus horarios");
            salon2_7am="libre";
            salon2_8am="libre";
            salon2_9am="libre";
            salon2_10am="libre";
            salon2_11am="libre";
            salon2_12pm="libre";
            salon2_1pm="libre";
            salon2_2pm="libre";
            salon2_3pm="libre";
            salon2_4pm="libre";
            salon2_5pm="libre";
            salon2_6pm="libre";
            salon2_7pm="libre";

        }
        public void cancelarMantenimientoSalon3(){
            Console.WriteLine("el salon 3 se retiro del mantenimiento en todos sus horarios");
            salon3_7am="libre";
            salon3_8am="libre";
            salon3_9am="libre";
            salon3_10am="libre";
            salon3_11am="libre";
            salon3_12pm="libre";
            salon3_1pm="libre";
            salon3_2pm="libre";
            salon3_3pm="libre";
            salon3_4pm="libre";
            salon3_5pm="libre";
            salon3_6pm="libre";
            salon3_7pm="libre";

        }
      public void iniciarClase(){
          Console.WriteLine("En que salon deseas iniciar la clase?: \n1-) salon 1 \n2-) salon 2\n3-) salon 3");
          OpcionUsuario = Console.ReadLine();
          if(OpcionUsuario=="1"){
            iniciarClaseSalon1();
            }
            else if(OpcionUsuario=="2"){
                 iniciarClaseSalon2();
            }
            else if(OpcionUsuario=="3"){
                 iniciarClaseSalon3();
            }
        }
      public void iniciarClaseSalon1(){
          Console.WriteLine("Que horario tienes la reserva para la clase: \n1-) 7am \n2-) 8am \n3-) 9am\n4-) 10am \n5-) 11am \n6-) 12am\n7-) 1pm \n8-) 2pm\n9-) 3pm\n10-) 4pm \n11-) 5pm \n12-) 6pm \n13-) 7pm");
          OpcionUsuario = Console.ReadLine();
        if( OpcionUsuario == "1" ){
          if( salon1_7am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_7am = "clase en curso";
          }
          else if(salon1_7am == "libre" || salon1_7am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "2" ){
          if( salon1_8am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_8am = "clase en curso";
          }
        else if(salon1_8am == "libre" || salon1_8am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "3" ){
          if( salon1_9am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_9am = "clase en curso";
          }
          else if(salon1_9am == "libre" || salon1_9am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "4" ){
          if( salon1_10am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_10am = "clase en curso";
          }
          else if(salon1_10am == "libre" || salon1_10am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "5" ){
          if( salon1_11am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_11am = "clase en curso";
          }
          else if(salon1_11am == "libre" || salon1_11am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "6" ){
          if( salon1_12pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_12pm = "clase en curso";
          }
          else if(salon1_12pm == "libre" || salon1_12pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "7" ){
          if( salon1_1pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_1pm = "clase en curso";
          }
          else if(salon1_1pm == "libre" || salon1_1pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "8" ){
          if( salon1_2pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_2pm = "clase en curso";
          }
          else if(salon1_2pm == "libre" || salon1_2pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "9" ){
          if( salon1_3pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_3pm = "clase en curso";
          }
          else if(salon1_3pm == "libre" || salon1_3pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "10" ){
          if( salon1_4pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_4pm = "clase en curso";
          }
          else if(salon1_4pm == "libre" || salon1_4pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "11" ){
          if( salon1_5pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_5pm = "clase en curso";
          }
          else if(salon1_5pm == "libre" || salon1_5pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "12" ){
          if( salon1_6pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_6pm = "clase en curso";
          }
          else if(salon1_6pm == "libre" || salon1_6pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "13" ){
          if( salon1_7pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon1_7pm = "clase en curso";
          }
          else if(salon1_7pm == "libre" || salon1_7pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        }
        public void iniciarClaseSalon2(){
          Console.WriteLine("Que horario tienes la reserva para la clase: \n1-) 7am \n2-) 8am \n3-) 9am\n4-) 10am \n5-) 11am \n6-) 12am\n7-) 1pm \n8-) 2pm\n9-) 3pm\n10-) 4pm \n11-) 5pm \n12-) 6pm \n13-) 7pm");
          OpcionUsuario = Console.ReadLine();
        if( OpcionUsuario == "1" ){
          if( salon2_7am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_7am = "clase en curso";
          }
          else if(salon2_7am == "libre" || salon2_7am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "2" ){
          if( salon2_8am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_8am = "clase en curso";
          }
        else if(salon2_8am == "libre" || salon2_8am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "3" ){
          if( salon2_9am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_9am = "clase en curso";
          }
          else if(salon2_9am == "libre" || salon2_9am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "4" ){
          if( salon2_10am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_10am = "clase en curso";
          }
          else if(salon2_10am == "libre" || salon2_10am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "5" ){
          if( salon2_11am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_11am = "clase en curso";
          }
          else if(salon2_11am == "libre" || salon2_11am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "6" ){
          if( salon2_12pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_12pm = "clase en curso";
          }
          else if(salon2_12pm == "libre" || salon2_12pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "7" ){
          if( salon2_1pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_1pm = "clase en curso";
          }
          else if(salon2_1pm == "libre" || salon2_1pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "8" ){
          if( salon2_2pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_2pm = "clase en curso";
          }
          else if(salon2_2pm == "libre" || salon2_2pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "9" ){
          if( salon2_3pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_3pm = "clase en curso";
          }
          else if(salon2_3pm == "libre" || salon2_3pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "10" ){
          if( salon2_4pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_4pm = "clase en curso";
          }
          else if(salon2_4pm == "libre" || salon2_4pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "11" ){
          if( salon2_5pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_5pm = "clase en curso";
          }
          else if(salon2_5pm == "libre" || salon2_5pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "12" ){
          if( salon2_6pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_6pm = "clase en curso";
          }
          else if(salon2_6pm == "libre" || salon2_6pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "13" ){
          if( salon2_7pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon2_7pm = "clase en curso";
          }
          else if(salon2_7pm == "libre" || salon2_7pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        }
        public void iniciarClaseSalon3(){
          Console.WriteLine("Que horario tienes la reserva para la clase: \n1-) 7am \n2-) 8am \n3-) 9am\n4-) 10am \n5-) 11am \n6-) 12am\n7-) 1pm \n8-) 2pm\n9-) 3pm\n10-) 4pm \n11-) 5pm \n12-) 6pm \n13-) 7pm");
          OpcionUsuario = Console.ReadLine();
        if( OpcionUsuario == "1" ){
          if( salon3_7am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_7am = "clase en curso";
          }
          else if(salon3_7am == "libre" || salon3_7am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "2" ){
          if( salon3_8am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_8am = "clase en curso";
          }
        else if(salon3_8am == "libre" || salon3_8am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "3" ){
          if( salon3_9am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_9am = "clase en curso";
          }
          else if(salon3_9am == "libre" || salon3_9am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "4" ){
          if( salon3_10am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_10am = "clase en curso";
          }
          else if(salon3_10am == "libre" || salon3_10am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "5" ){
          if( salon3_11am == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_11am = "clase en curso";
          }
          else if(salon3_11am == "libre" || salon3_11am == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "6" ){
          if( salon3_12pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_12pm = "clase en curso";
          }
          else if(salon3_12pm == "libre" || salon3_12pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "7" ){
          if( salon3_1pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_1pm = "clase en curso";
          }
          else if(salon3_1pm == "libre" || salon3_1pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "8" ){
          if( salon3_2pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_2pm = "clase en curso";
          }
          else if(salon3_2pm == "libre" || salon3_2pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "9" ){
          if( salon3_3pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_3pm = "clase en curso";
          }
          else if(salon3_3pm == "libre" || salon3_3pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "10" ){
          if( salon3_4pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_4pm = "clase en curso";
          }
          else if(salon3_4pm == "libre" || salon3_4pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "11" ){
          if( salon3_5pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_5pm = "clase en curso";
          }
          else if(salon3_5pm == "libre" || salon3_5pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "12" ){
          if( salon3_6pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_6pm = "clase en curso";
          }
          else if(salon3_6pm == "libre" || salon3_6pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        if( OpcionUsuario == "13" ){
          if( salon3_7pm == "reservado" ){
              Console.WriteLine("Clase iniciada");
              Console.WriteLine("Puertas abiertas\nTemperatura 23 °C");
              salon3_7pm = "clase en curso";
          }
          else if(salon3_7pm == "libre" || salon3_7pm == "mantenimiento"){
              Console.WriteLine("No es posible iniciar la clase");
          }
        }
        }
        #endregion Methods
        #endregion Properties
    }
}
