using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarketStore.ModelViews
{
    public class OrderVM
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter your first and last name")]
        public string FullName { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter youe email")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter the phone number")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter address")]
        //public int TinhThanh { get; set; }
        //[Required(ErrorMessage = "Vui lòng chọn Quận/Huyện")]
        //public int QuanHuyen { get; set; }
        //[Required(ErrorMessage = "Vui lòng chọn Phường/Xã")]
        //public int PhuongXa { get; set; }
        public int PaymentID { get; set; }
        public string Note { get; set; }
    }
}
