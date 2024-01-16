from django.urls import path
from . import views

urlpatterns = [
     
    path('', views.home),
    path('home/', views.home),
    path('add-adoption/',views.add_adoption),
    path('delete-dashboard/<int:name>',views.delete_dashboard),
    path('update-dashboard/<int:name>',views.update_dashboard),
    path('do-update-dashboard/<int:name>',views.do_update_dashboard),
]
