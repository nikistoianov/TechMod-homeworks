<?php

/* base.html.twig */
class __TwigTemplate_c72e15251095222fc116d271fa04689b9d313c7db740bdb69071174d1b90d96e extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_4feb93be1419d48f05df90e2e8e8dffe0ac069015c64efb644bf2dee32193934 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4feb93be1419d48f05df90e2e8e8dffe0ac069015c64efb644bf2dee32193934->enter($__internal_4feb93be1419d48f05df90e2e8e8dffe0ac069015c64efb644bf2dee32193934_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_4feb93be1419d48f05df90e2e8e8dffe0ac069015c64efb644bf2dee32193934->leave($__internal_4feb93be1419d48f05df90e2e8e8dffe0ac069015c64efb644bf2dee32193934_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_e6f1bd0d78bd63756a1c668ff26ae3ff405386ecc1a414d86ecae96dc957f9fd = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e6f1bd0d78bd63756a1c668ff26ae3ff405386ecc1a414d86ecae96dc957f9fd->enter($__internal_e6f1bd0d78bd63756a1c668ff26ae3ff405386ecc1a414d86ecae96dc957f9fd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_e6f1bd0d78bd63756a1c668ff26ae3ff405386ecc1a414d86ecae96dc957f9fd->leave($__internal_e6f1bd0d78bd63756a1c668ff26ae3ff405386ecc1a414d86ecae96dc957f9fd_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_bf2ff9148c56bfadeb4b7059a0da78dcf8d714f13d7a09b5b9a76517ab7c4c52 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bf2ff9148c56bfadeb4b7059a0da78dcf8d714f13d7a09b5b9a76517ab7c4c52->enter($__internal_bf2ff9148c56bfadeb4b7059a0da78dcf8d714f13d7a09b5b9a76517ab7c4c52_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_bf2ff9148c56bfadeb4b7059a0da78dcf8d714f13d7a09b5b9a76517ab7c4c52->leave($__internal_bf2ff9148c56bfadeb4b7059a0da78dcf8d714f13d7a09b5b9a76517ab7c4c52_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_4ea432fcac41c9347a145afb503559d485d33bd2bc05df23c00979ba4697056b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4ea432fcac41c9347a145afb503559d485d33bd2bc05df23c00979ba4697056b->enter($__internal_4ea432fcac41c9347a145afb503559d485d33bd2bc05df23c00979ba4697056b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_4ea432fcac41c9347a145afb503559d485d33bd2bc05df23c00979ba4697056b->leave($__internal_4ea432fcac41c9347a145afb503559d485d33bd2bc05df23c00979ba4697056b_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_4d4a93cfd6f77d612bcab1fed8859ff628bfa40614be0d817e9d8f37a15aa989 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4d4a93cfd6f77d612bcab1fed8859ff628bfa40614be0d817e9d8f37a15aa989->enter($__internal_4d4a93cfd6f77d612bcab1fed8859ff628bfa40614be0d817e9d8f37a15aa989_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_4d4a93cfd6f77d612bcab1fed8859ff628bfa40614be0d817e9d8f37a15aa989->leave($__internal_4d4a93cfd6f77d612bcab1fed8859ff628bfa40614be0d817e9d8f37a15aa989_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_4456b893674707040b012866e55d0e9edbc20d172a9a3ed8022e1b786dd9cfce = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4456b893674707040b012866e55d0e9edbc20d172a9a3ed8022e1b786dd9cfce->enter($__internal_4456b893674707040b012866e55d0e9edbc20d172a9a3ed8022e1b786dd9cfce_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_4456b893674707040b012866e55d0e9edbc20d172a9a3ed8022e1b786dd9cfce->leave($__internal_4456b893674707040b012866e55d0e9edbc20d172a9a3ed8022e1b786dd9cfce_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_eeff24bf0a1865c351dedfd41d46e81457810f1b7525e93d40634318999ded5f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_eeff24bf0a1865c351dedfd41d46e81457810f1b7525e93d40634318999ded5f->enter($__internal_eeff24bf0a1865c351dedfd41d46e81457810f1b7525e93d40634318999ded5f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_eeff24bf0a1865c351dedfd41d46e81457810f1b7525e93d40634318999ded5f->leave($__internal_eeff24bf0a1865c351dedfd41d46e81457810f1b7525e93d40634318999ded5f_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_78a73f2ff0c0b0f70cbff7f9b98e08fed53d276a0be5f96b2bc19782a61a8f3e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_78a73f2ff0c0b0f70cbff7f9b98e08fed53d276a0be5f96b2bc19782a61a8f3e->enter($__internal_78a73f2ff0c0b0f70cbff7f9b98e08fed53d276a0be5f96b2bc19782a61a8f3e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_78a73f2ff0c0b0f70cbff7f9b98e08fed53d276a0be5f96b2bc19782a61a8f3e->leave($__internal_78a73f2ff0c0b0f70cbff7f9b98e08fed53d276a0be5f96b2bc19782a61a8f3e_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
