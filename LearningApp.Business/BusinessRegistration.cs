﻿using LearningApp.Business.Interfaces;
using LearningApp.Business.Services;
using LearningApp.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace LearningApp.Business
{
    public static class BusinessRegistration
    {
        public static void AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IInstructorService, InstructorService>();
            services.AddDataServices(configuration);
        }
    }
}
