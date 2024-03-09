using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCoursesReservation.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataInTableFaq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "FAQs",
            columns: new[] { "Question", "Answer" },
            values: new object[,]
            {
                {
                    "كيف يمكنني التسجيل في دورة في مركز خدمة المجتمع؟",
                    "يمكنك التسجيل في دورة في مركز خدمة المجتمع عن طريق زيارة الموقع الإلكتروني للمركز والتسجيل عبر النموذج المتاح، أو يمكنك التواصل مع الإدارة مباشرة للمساعدة في عملية التسجيل."
                },
                {
                    "هل تقدمون خصومات للطلاب أو الفئات الخاصة؟",
                    "نعم، نقدم خصومات للطلاب والفئات الخاصة وفقاً للسياسات المعتمدة في المركز. يُرجى التواصل مع الإدارة لمعرفة التفاصيل والشروط المطلوبة للحصول على الخصم."
                },
                {
                    "ما هي سياسة إلغاء الحجز واسترداد الرسوم؟",
                    "يُمكن إلغاء الحجز واسترداد الرسوم وفقاً لسياسة المركز. يُرجى الرجوع إلى الشروط والأحكام المتعلقة بسياسة إلغاء الحجز واسترداد الرسوم المتاحة على الموقع الإلكتروني للمركز."
                },
                {
                    "هل يمكنني الحصول على مزيد من المعلومات حول المعلمين وخبراتهم؟",
                    "نعم، يمكنك الحصول على مزيد من المعلومات حول المعلمين وخبراتهم عن طريق الاطلاع على صفحاتهم الشخصية على الموقع الإلكتروني للمركز أو من خلال التواصل مع الإدارة لطلب المعلومات اللازمة."
                }
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from FAQs");
        }
    }
}
