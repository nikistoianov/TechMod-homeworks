<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_c3629119421762b38adc034ef3862f053e2080fad8e229790f29c91571ca3893 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_30f6133dd017148015ab72dc955b63833eba1298830542e59de6b5f8f367aba0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_30f6133dd017148015ab72dc955b63833eba1298830542e59de6b5f8f367aba0->enter($__internal_30f6133dd017148015ab72dc955b63833eba1298830542e59de6b5f8f367aba0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_30f6133dd017148015ab72dc955b63833eba1298830542e59de6b5f8f367aba0->leave($__internal_30f6133dd017148015ab72dc955b63833eba1298830542e59de6b5f8f367aba0_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_1b13cdf42e47ffc8b2ed24e734c5182cd804bf99b89c5026ba61d2cfdae5590b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1b13cdf42e47ffc8b2ed24e734c5182cd804bf99b89c5026ba61d2cfdae5590b->enter($__internal_1b13cdf42e47ffc8b2ed24e734c5182cd804bf99b89c5026ba61d2cfdae5590b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_1b13cdf42e47ffc8b2ed24e734c5182cd804bf99b89c5026ba61d2cfdae5590b->leave($__internal_1b13cdf42e47ffc8b2ed24e734c5182cd804bf99b89c5026ba61d2cfdae5590b_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_10f2a64a493faa7a0c0b3cd9b3084ac14bdb16df2d51b8c9d2ad20e97f7de021 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_10f2a64a493faa7a0c0b3cd9b3084ac14bdb16df2d51b8c9d2ad20e97f7de021->enter($__internal_10f2a64a493faa7a0c0b3cd9b3084ac14bdb16df2d51b8c9d2ad20e97f7de021_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_10f2a64a493faa7a0c0b3cd9b3084ac14bdb16df2d51b8c9d2ad20e97f7de021->leave($__internal_10f2a64a493faa7a0c0b3cd9b3084ac14bdb16df2d51b8c9d2ad20e97f7de021_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_5394fe9c86c2fc31b07e8e2cd76552913cf8ead6dfb5e079aad5a95afa7e22ad = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5394fe9c86c2fc31b07e8e2cd76552913cf8ead6dfb5e079aad5a95afa7e22ad->enter($__internal_5394fe9c86c2fc31b07e8e2cd76552913cf8ead6dfb5e079aad5a95afa7e22ad_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_5394fe9c86c2fc31b07e8e2cd76552913cf8ead6dfb5e079aad5a95afa7e22ad->leave($__internal_5394fe9c86c2fc31b07e8e2cd76552913cf8ead6dfb5e079aad5a95afa7e22ad_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
