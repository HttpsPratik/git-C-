from django.shortcuts import render,redirect

import dashboard
from .models import Comment



def home(request):
    dashboard = Comment.objects.all()
    return render(request, 'dashboard/home.html',{'dashboard':dashboard})

def add_adoption(request):
  if request.method=='POST':
    print ("Added")
    dashboard_email =  request.POST.get("dashboard_email")
    dashboard_title =  request.POST.get("dashboard_title")
    dashboard_description = request.POST.get("dashboard_description")
    dashboard_image = request.POST.get("dashboard_image")


    s = Comment()
    s.email = dashboard_email
    s.title = dashboard_title
    s.description = dashboard_description
    s.image = dashboard_image
    
    s.save()
    return redirect("/dashboard/home")
  

  return render(request, 'dashboard/add_adoption.html',{})

def delete_dashboard(request,name):
   s=Comment.objects.get(pk=name)
   s.delete()

   return redirect("/dashboard/home/")
  
def update_dashboard(request, name):
   dashboard=Comment.objects.get(pk=name)
   return render(request,"dashboard/update_adoption.html",{'dashboard':dashboard})

def do_update_dashboard(request, name):
    dashboard_email =  request.POST.get("dashboard_email")
    dashboard_title =  request.POST.get("dashboard_title")
    dashboard_description = request.POST.get("dashboard_description")
    dashboard_image = request.POST.get("dashboard_image")

    dashboard=Comment.objects.get(pk=name)
    dashboard.email = dashboard_email
    dashboard.title = dashboard_title
    dashboard.description = dashboard_description
    dashboard.image = dashboard_image
    
    dashboard.save()
    return redirect("/dashboard/home")
