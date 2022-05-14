using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LessonManager>().As<ILessonService>();
            builder.RegisterType<EfLessonRepository>().As<ILessonRepository>();

            builder.RegisterType<StudentManager>().As<IStudentService>();
            builder.RegisterType<EfStudentRepository>().As<IStudentRepository>();

            builder.RegisterType<TeacherManager>().As<ITeacherService>();
            builder.RegisterType<EfTeacherRepository>().As<ITeacherRepository>();
        }
    }
}