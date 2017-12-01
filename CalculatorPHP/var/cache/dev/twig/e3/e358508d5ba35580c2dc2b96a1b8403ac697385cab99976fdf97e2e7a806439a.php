<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_a5312bcc282fc257137ea50bb5e5e550b35bdc25a47f28f07497f7895397c390 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_1bfa208c073e4540669273cc5719d11d0d0a37886a9d27b084e015d92929f6ed = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1bfa208c073e4540669273cc5719d11d0d0a37886a9d27b084e015d92929f6ed->enter($__internal_1bfa208c073e4540669273cc5719d11d0d0a37886a9d27b084e015d92929f6ed_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_1bfa208c073e4540669273cc5719d11d0d0a37886a9d27b084e015d92929f6ed->leave($__internal_1bfa208c073e4540669273cc5719d11d0d0a37886a9d27b084e015d92929f6ed_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_331f8bb3ca2c515dea1fe2454dcda41df640905b10c4372d41a4d6d1a1f9ba48 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_331f8bb3ca2c515dea1fe2454dcda41df640905b10c4372d41a4d6d1a1f9ba48->enter($__internal_331f8bb3ca2c515dea1fe2454dcda41df640905b10c4372d41a4d6d1a1f9ba48_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_331f8bb3ca2c515dea1fe2454dcda41df640905b10c4372d41a4d6d1a1f9ba48->leave($__internal_331f8bb3ca2c515dea1fe2454dcda41df640905b10c4372d41a4d6d1a1f9ba48_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_42504b26ba61b8b235dc106e51b7125ed4d59a0356c8e2debc37d087338ac9f9 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_42504b26ba61b8b235dc106e51b7125ed4d59a0356c8e2debc37d087338ac9f9->enter($__internal_42504b26ba61b8b235dc106e51b7125ed4d59a0356c8e2debc37d087338ac9f9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_42504b26ba61b8b235dc106e51b7125ed4d59a0356c8e2debc37d087338ac9f9->leave($__internal_42504b26ba61b8b235dc106e51b7125ed4d59a0356c8e2debc37d087338ac9f9_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_3c6d1dc17a40c89b3126b0680f4cdc4bc9402eb5ed82feb94e7bf4e4bfed97be = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3c6d1dc17a40c89b3126b0680f4cdc4bc9402eb5ed82feb94e7bf4e4bfed97be->enter($__internal_3c6d1dc17a40c89b3126b0680f4cdc4bc9402eb5ed82feb94e7bf4e4bfed97be_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_3c6d1dc17a40c89b3126b0680f4cdc4bc9402eb5ed82feb94e7bf4e4bfed97be->leave($__internal_3c6d1dc17a40c89b3126b0680f4cdc4bc9402eb5ed82feb94e7bf4e4bfed97be_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
