using MobilePhone.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labs.Output;
using MobilePhone.Output;
using MobilePhone.PhoneJack;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            var simCorpPhone = new SimCorpPhone();
            Console.WriteLine(simCorpPhone.GetDescription());

            SetPhoneJack(simCorpPhone);
            PlaySound(simCorpPhone);

            Console.ReadKey();
        }

        static void PlaySound(MobilePhoneBase mobile)
        {
            Console.WriteLine(" Play sound in Mobile:");
            mobile.Play(null);
        }

        static void SetPhoneJack(MobilePhoneBase mobile)
        {
            string menuTxt = GetMenuTxt();
            Console.WriteLine(menuTxt);

            while (true)
            {
                try
                {
                    int userChoice = Int32.Parse(Console.ReadLine());
                    IPlayback playback;
                    var output = new ConsoleOutput();

                    switch (userChoice)
                    {
                        case 1:
                            playback = new iPhoneHeadset(output);
                            break;
                        case 2:
                            playback = new SamsungHeadset(output);
                            break;
                        case 3:
                            playback = new UnofficialiPhoneHeadset(output);
                            break;
                        case 4:
                            playback = new PhoneSpeaker(output);
                            break;
                        default:
                            throw new ArgumentException(" Your choice is out of scope menu options");
                    }

                    Console.WriteLine(" "+playback.GetType().ToString()+ " playback selected");
                    mobile.PlaybackComponent = playback;
                    return;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Use digits for menu options");
                }
                catch
                {
                    throw;
                }
            }
        }

        static string GetMenuTxt()
        {
            var menuTxt = new StringBuilder();
            menuTxt.AppendLine(" Select playback component (specify index):");
            menuTxt.AppendLine($" 1 - {nameof(iPhoneHeadset)}");
            menuTxt.AppendLine($" 2 - {nameof(SamsungHeadset)}");
            menuTxt.AppendLine($" 3 - {nameof(UnofficialiPhoneHeadset)}");
            menuTxt.AppendLine($" 4 - {nameof(PhoneSpeaker)}");
            return menuTxt.ToString();
        }

    }
}
